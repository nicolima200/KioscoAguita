import os
import sqlite3

SQL = [
    'CREATE INDEX IF NOT EXISTS idx_detalleVentas_idVenta ON detalleVentas(idVenta)',
    'CREATE INDEX IF NOT EXISTS idx_ventas_fecha ON VENTAS(fecha)',
]


def main(ruta):
    con = sqlite3.connect(ruta, isolation_level=None)
    cur = con.cursor()
    tam_antes = os.path.getsize(ruta)
    for stmt in SQL:
        cur.execute(stmt)
    cur.execute('ANALYZE')
    cur.execute('VACUUM')
    tam_despues = os.path.getsize(ruta)
    indices = [(r[0], r[1]) for r in cur.execute("select name, tbl_name from sqlite_master where type='index' and name not like 'sqlite_%'")]
    print('=== ' + ruta + ' ===')
    print('indices:', indices)
    print('tamanio : %.1f MB -> %.1f MB' % (tam_antes / 1e6, tam_despues / 1e6))
    con.close()


if __name__ == '__main__':
    import sys
    for ruta in sys.argv[1:]:
        main(ruta)
