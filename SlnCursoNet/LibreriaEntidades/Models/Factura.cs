using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEntidades.Models
{
    public class Factura
    {
        #region Propiedades Autoimplementadas
        public string Tipo { get; set; }
        public string Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Direccion { get; set; }
        public string CondicionIVA { get; set; }
        public string CondicionVenta { get; set; }
        public string Detalle { get; set; }
        public decimal Total { get; set; }
        #endregion

        #region Constructores
        public Factura(string tipo, string numero, DateTime fecha, string direccion, string condicionIVA, string condicionVenta, string detalle, decimal total)
        {
            Tipo = tipo;
            Numero = numero;
            Fecha = fecha;
            Direccion = direccion;
            CondicionIVA = condicionIVA;
            CondicionVenta = condicionVenta;
            Detalle = detalle;
            Total = total;
        }
        #endregion
    }
}
