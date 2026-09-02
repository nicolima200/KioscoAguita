import shutil
import sqlite3
import sys
import unicodedata

SQL_TABLAS = """
CREATE TABLE productos_nuevo (
    id INTEGER PRIMARY KEY,
    codBarras TEXT,
    nombre TEXT NOT NULL,
    descripcion TEXT,
    categoriaId INTEGER REFERENCES categorias(id),
    marca TEXT DEFAULT 'Sin marca',
    urlImagen TEXT,
    tipoVenta TEXT NOT NULL DEFAULT 'Unidad'
);

CREATE TABLE productos_inventario (
    idProducto INTEGER PRIMARY KEY REFERENCES productos(id),
    stock REAL DEFAULT 0,
    stockMinimo REAL DEFAULT 0,
    precioKiosco REAL,
    precioMayorista REAL,
    activo INTEGER DEFAULT 1
);
"""

COLUMNAS_VIEJAS = 'id, codBarras, nombre, descripcion, categoria, precioMayorista, precioKiosco, stock, stockMinimo, activo, urlImagen, tipoVenta, marca'


def normalizar(texto):
    if texto is None:
        return ''
    texto = texto.strip().casefold()
    texto = unicodedata.normalize('NFD', texto)
    return ''.join(c for c in texto if not unicodedata.combining(c))


def main(ruta):
    backup = ruta + '.bak-pre-split'
    if not __import__('os').path.exists(backup):
        shutil.copy2(ruta, backup)
        print('backup: ' + backup)

    con = sqlite3.connect(ruta, isolation_level=None)
    cur = con.cursor()

    if cur.execute("select count(*) from sqlite_master where type='table' and name='productos_inventario'").fetchone()[0]:
        print('ABORT: ' + ruta + ' ya migrada (productos_inventario existe)')
        return

    cur.execute('PRAGMA foreign_keys=OFF')

    categorias = {}
    for cid, desc in cur.execute('select id, descripcion from categorias'):
        categorias.setdefault(normalizar(desc), cid)

    cur.execute('BEGIN')
    duplicadas = {}
    for cid, desc in cur.execute('select id, descripcion from categorias').fetchall():
        clave = normalizar(desc)
        if clave in duplicadas:
            cur.execute('delete from categorias where id = ?', (cid,))
        else:
            duplicadas[clave] = cid
    cur.execute('COMMIT')
    categorias = duplicadas

    creadas = {}
    mapeos = {}
    sin_categoria = 0

    filas = cur.execute('select ' + COLUMNAS_VIEJAS + ' from productos').fetchall()

    cur.execute('BEGIN')
    for stmt in [s.strip() for s in SQL_TABLAS.split(';') if s.strip()]:
        cur.execute(stmt)

    for fila in filas:
        pid, cod, nom, desc, cat, may, kio, sto, stmin, act, url, tv, marca = fila
        clave = normalizar(cat)

        if not clave:
            cid = None
            sin_categoria += 1
        elif clave in categorias:
            cid = categorias[clave]
            mapeos[cat.strip()] = cid
        else:
            prefijos = [cid for k, cid in categorias.items() if k.startswith(clave) and len(clave) >= 3]
            if len(prefijos) == 1:
                cid = prefijos[0]
                mapeos[cat.strip()] = cid
            else:
                cur.execute('insert into categorias (descripcion) values (?)', (cat.strip(),))
                cid = cur.lastrowid
                categorias[clave] = cid
                creadas[cat.strip()] = cid

        cur.execute(
            'insert into productos_nuevo (id, codBarras, nombre, descripcion, categoriaId, marca, urlImagen, tipoVenta) values (?,?,?,?,?,?,?,?)',
            (pid, cod, nom, desc, cid, marca, url, tv))
        cur.execute(
            'insert into productos_inventario (idProducto, stock, stockMinimo, precioKiosco, precioMayorista, activo) values (?,?,?,?,?,?)',
            (pid, sto, stmin, kio, may, act))

    cur.execute('drop table productos')
    cur.execute('alter table productos_nuevo rename to productos')
    cur.execute('create index idx_productos_codBarras on productos(codBarras)')
    cur.execute('COMMIT')
    cur.execute('PRAGMA foreign_keys=ON')

    violaciones = cur.execute('pragma foreign_key_check').fetchall()
    print('')
    print('=== ' + ruta + ' ===')
    print('productos migrados : ' + str(len(filas)))
    print('categorias creadas : ' + (str(creadas) if creadas else 'ninguna'))
    print('sin categoria      : ' + str(sin_categoria))
    print('violaciones FK     : ' + str(len(violaciones)))
    con.close()


if __name__ == '__main__':
    for ruta in sys.argv[1:]:
        main(ruta)
