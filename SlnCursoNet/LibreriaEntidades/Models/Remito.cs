using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEntidades.Models
{
    public class Remito
    {
        #region Propiedades Autoimplementadas
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public string CondicionIVA { get; set; }
        public string CondicionVenta { get; set; }
        public string Detalle { get; set; }
        public DateTime FechaEntrega { get; set; }
        public decimal Total { get; set; }
        #endregion

        #region Constructor
        public Remito(string numero, DateTime fecha, string cliente, string direccion, string condicionIVA, string condicionVenta, string detalle, DateTime fechaEntrega, decimal total)
        {
            Numero = numero;
            Fecha = fecha;
            Cliente = cliente;
            Direccion = direccion;
            CondicionIVA = condicionIVA;
            CondicionVenta = condicionVenta;
            Detalle = detalle;
            FechaEntrega = fechaEntrega;
            Total = total;
        }
        #endregion
    }
}
