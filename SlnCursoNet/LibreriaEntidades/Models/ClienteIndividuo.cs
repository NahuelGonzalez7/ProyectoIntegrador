﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEntidades.Models
{
    public class ClienteIndividuo
    {
        #region Propiedades Autoimplementadas
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string CUIT { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        #endregion

        #region Constructor
        public ClienteIndividuo(string nombre, string apellido, string cUIT, string email, string telefono, string direccion)
        {
            Nombre = nombre;
            Apellido = apellido;
            CUIT = cUIT;
            Email = email;
            Telefono = telefono;
            Direccion = direccion;
        }
        #endregion
    }
}
