using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjBoleta
{
    public partial class Boleta : Form
    {

        //Variables globales 
        int num;
        ClBoleta obj = new ();
        public Boleta()
        {
            InitializeComponent();
        }

        private void Boleta_Load(object sender, EventArgs e)
        {
            num++;
            lblNumero.Text = num.ToString("D5");
            txtFecha.Text = DateTime.Now.ToShortDateString();

        }

        private void lstProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj.DescripcionProducto = lstProducto.Text;
            txtPrecio.Text = obj.DeterminarPrecio().ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Valida()== "")
            {
                // Capturar datos

                CapturaDatos();

                //Determinar los calculos de la aplicacion

                double precio = obj.DeterminarPrecio();
                double importe = obj.CalcularImporte();


                // imprimir el detalle de la venta

                ImprimirDetalle(precio, importe);


                // imprimir el total acumulado
                lblTotal.Text = DeterminaTotal().ToString("C");

            }else
            {
                MessageBox.Show($"El error se encuentra {Valida()}");
            }
        }

        private double DeterminaTotal()
        {
           double total = 0;
            for(int i = 0; i < lvDatosProducto.Items.Count; i++)
            {
                total +=Convert.ToDouble(lvDatosProducto.Items[i].SubItems[3].Text);
            }
            return total;
        }

        private void ImprimirDetalle(double precio, double importe)
        {
            ListViewItem fila = new(obj.CantidadComprada.ToString());
            fila.SubItems.Add(obj.DescripcionProducto);
            fila.SubItems.Add(precio.ToString("0.00"));
            fila.SubItems.Add(importe.ToString("0.00"));
            lvDatosProducto.Items.Add(fila);
        }

        private void CapturaDatos()
        {
            obj.NumeroBoleta= Convert.ToInt32(lblNumero.Text);
            obj.DireccionCliente= txtCliente.Text;
            obj.CedulaCliente= txtCedula.Text;
            obj.NombreCliente = txtCliente.Text;
            obj.FechaRegistro= DateTime.Parse(txtFecha.Text);
            obj.DescripcionProducto = lstProducto.Text;
            obj.CantidadComprada = int.Parse(txtCantidad.Text);

        }

        private string Valida()
        {
            if (txtCliente.Text.Trim().Length == 0)
            {
                txtCliente.Focus();
                return "nombre del cliente";
            }
            else if (txtCedula.Text.Trim().Length == 1)
            {
                txtCedula.Focus();
                return "cedula del cliente";
            }
            else if(txtDireccion.Text.Trim().Length == 0)
            {
                txtDireccion.Focus();
                return "direccion del cliente";
            }
            else if (lstProducto.SelectedIndex == -1)
            {
                lstProducto.Focus();
                return "descripcion del producto";
            }
            else if (txtCantidad.Text.Trim().Length == 0)
            {
                txtCantidad.Focus();
                return "cantidad del producto";
            }
            return "";
        }

        private void btnIngresarBoleta_Click(object sender, EventArgs e)
        {
            ListViewItem fila = new(obj.CantidadComprada.ToString());
            fila.SubItems.Add(txtFecha.Text);
            fila.SubItems.Add(TotalCantidad().ToString());
            fila.SubItems.Add(DeterminaTotal().ToString("C"));
            lvResumenBoletas.Items.Add(fila);
            LimpiarControles();
        }

        private void LimpiarControles()
        {
            num++;
            lblNumero.Text = num.ToString("D5");
            txtCliente.Clear();
            txtCantidad.Clear();
            txtCedula.Clear();
            txtDireccion.Clear();
            txtPrecio.Clear();
            
        }
        //Total de productos por boleta
        private int TotalCantidad()
        {
            int total= 0;

          for(int i = 0; i < lvResumenBoletas.Items.Count; i++)
            {
                total += Convert.ToInt32(lvResumenBoletas.Items[i].SubItems[0].Text);
            }
            return total;
        }
    }
}
