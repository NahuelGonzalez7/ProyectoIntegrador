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

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInstanciarClases_Click(object sender, EventArgs e)
        {
            Producto producto1 = new Producto("Heladera", "Color blanco, capacidad maxima 16 kilos", 100, 20, 21, "Philips", "Electrodomesticos para el hogar", "Grandes electrodomesticos");

            MessageBox.Show("PRODUCTO: " + "\n Producto:" + producto1.Nombre + "\n Descripcion: " + producto1.Descripcion + "\n Precio costo: " + producto1.PrecioCosto + "\n Margen: " + producto1.Margen + "\n IVA:" + producto1.IVA + "\n Precio Bruto: " + producto1.PrecioBruto + "\n Precio Venta: " + producto1.PrecioVenta + "\n Proveedor: " + producto1.Proveedor + "\n Categoria: " + producto1.Categoria + "\n Sub categoria:" + producto1.SubCategoria);

            Proveedor proveedor = new Proveedor("Philips", "23456892093", "Maximo","Philips.arg@gmail.com", "0800 - 888 - 7532","Belgrano 3509");

            MessageBox.Show("PROVEEDOR:" + "\n Nombre:" + proveedor.Nombre + "\n CUIT: " + proveedor.CUIT + "\n Contacto: " + proveedor.Contacto + "\n Email: " + proveedor.Email + "\n Telefono:" + proveedor.Telefono + "\n Direccion: " + proveedor.Direccion);

            ClienteIndividuo cliente1 = new ClienteIndividuo("Juan carlos", "Perez", "23257800999", "JuanCaP@gmail.com", "4987420", "San salvador 7155");

            MessageBox.Show("CLIENTE: " + "\n Nombre:" + cliente1.Nombre + "\n Apellido: " + cliente1.Apellido + "\n CUIT: " + cliente1.CUIT + "\n Email: " + cliente1.Email + "\n Telefono:" + cliente1.Telefono + "\n Direccion: " + cliente1.Direccion);

            ClienteEmpresa clienteEmpresa1 = new ClienteEmpresa("\n TecnologiaTuAlcance", "20255459482", "Hernan", "tecnologiatualcancesrl@gmail.com", "451-0028", "Alem 3345");

            MessageBox.Show("CLIENTE EMPRESA: " + "\n Nombre cliente empresa:" + clienteEmpresa1.Nombre + "\n CUIT: " + clienteEmpresa1.CUIT + "\n Contacto: " + clienteEmpresa1 + "\n Email: " + clienteEmpresa1.Email + "\n Telefono:" + clienteEmpresa1.Telefono + "\n Direccion: " + clienteEmpresa1.Direccion);

            Vendedor vendedor1 = new Vendedor("Daniel", "Gonzalez", "23678091", "danilocure@gmail.com", "2236780192", "De las aguas 1123");

            MessageBox.Show("VENDEDOR: " + "\n Nombre Vendedor :" + vendedor1.Nombre + "\n Apellido: " + vendedor1.Apellido + "\n DNI: " + vendedor1.DNI + "\n Email: " + vendedor1.Email + "\n Telefono:" + vendedor1.Telefono + "\n Direccion: " + vendedor1.Direccion);

            Factura factura = new Factura("A", "22", Convert.ToDateTime("22/10/2020"),"Las heras 3300","Responsable inscripto", " - ", "Heladera Philips",1300);

            MessageBox.Show("FACTURA: " + "\n Tipo Factura :" + factura.Tipo + "\n Numero: " + factura.Numero + "\n Fecha Factura: " + factura.Fecha.ToShortDateString() + "\n Condicion Iva: " + factura.CondicionIVA + "\n Condicion Venta:" + factura.CondicionVenta + "\n Detalle: " + factura.Detalle + "Total: " + factura.Total);

            Remito remito = new Remito("10", Convert.ToDateTime("20/12/2020"), "Hernan Javier", "Falucho 6030", "Consumidor Final", " - ", " Heladera Philips", Convert.ToDateTime("21/12/2020"), 1300);

            MessageBox.Show("REMITO: "+ "\n Numero Remito :" + remito.Numero +  "\n Fecha Remito: " + remito.Fecha.ToShortDateString() + "\n Cliente " + remito.Cliente + "\n Direccion:" + remito.Direccion + "\n Condicion IVA: " + remito.CondicionIVA + "\n Condicion Venta " + remito.CondicionVenta + "\n Detalle:" + remito.Detalle + "Fecha entrega: " + remito.FechaEntrega.ToShortDateString() + "Total: " + remito.Total);
        }
    }
}
