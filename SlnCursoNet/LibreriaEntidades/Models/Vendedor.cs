using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEntidades.Models
{
    public class Vendedor
    {
        #region Propiedades Autoimplementadas
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        #endregion

        #region Constructor
        public Vendedor(string nombre, string apellido, string dNI, string email, string telefono, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dNI;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }
        #endregion
    }
}
