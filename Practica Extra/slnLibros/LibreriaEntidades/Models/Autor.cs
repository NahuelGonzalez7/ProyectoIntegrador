using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEntidades.Models
{
    public class Autor
    {
        #region Propiedades Autoimplementadas
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Domicilio { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        #endregion

        #region Constructores
        public Autor(string nombre, string apellido, DateTime fechaNacimiento, string domicilio, string ciudad, string pais)
        {
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
            Domicilio = domicilio;
            Ciudad = ciudad;
            Pais = pais;
        }
        #endregion
    }
}
