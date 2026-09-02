using dominio.enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Venta
    {
        public Venta()
        {
            Fecha = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        [DisplayName("Forma de pago")]
        public FormaPago FormaPago { get; set; }
        [DisplayName("TOTAL")]
        public decimal MontoTotal { get; set; }
        [DisplayName("Cliente pagó con")]
        public decimal MontoPago { get; set; }
        public decimal Vuelto { get; set; }
        [DisplayName("Referencia")]
        public string referencia { get; set; }


    }
}
