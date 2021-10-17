using LibreriaEntidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPracticaExtra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnObjetoPrueba_Click(object sender, EventArgs e)
        {
            Publicador publicador = new Publicador("Galerna", "Mar del Plata", "Rivadavia 2089", "LibGalerna@gmail.com", "Argentina");

            MessageBox.Show("\n PUBLICADOR: " + "\n Nombre: " + publicador.Nombre + "\n Ciudad: " + publicador.Ciudad + "\n Domicilio:" + publicador.Domicilio + "\n Contacto: " + publicador.Contacto + "\n Pais:" + publicador.Pais);
        }
    }
}
