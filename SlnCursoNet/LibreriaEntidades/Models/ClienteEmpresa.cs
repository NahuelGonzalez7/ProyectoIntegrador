using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEntidades.Models
{
    public class ClienteEmpresa
    {
        #region Propiedades Autoimplentadas
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public string Contacto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        #endregion

        #region Constructores
        public ClienteEmpresa(string nombre, string cUIT, string contacto, string email, string telefono, string direccion)
        {
            Nombre = nombre;
            CUIT = cUIT;
            Contacto = contacto;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }
        #endregion
    }
}
