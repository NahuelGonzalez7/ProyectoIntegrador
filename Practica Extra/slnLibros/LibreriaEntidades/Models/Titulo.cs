using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEntidades.Models
{
    public class Titulo
    {
        #region Propiedades Autoimplementadas
        public string NombreAutor { get; set; }
        public string TituloLibro { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public string Notas { get; set; }
        #endregion
        #region Constructores

        public Titulo(string nombreAutor, string tituloLibro, string categoria, decimal precio, string notas)
        {
            NombreAutor = nombreAutor;
            TituloLibro = tituloLibro;
            Categoria = categoria;
            Precio = precio;
            Notas = notas;
        }
        #endregion
    }
}
