using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjPruebaAnotaciones
{
    public partial class frmPrueba : Form
    {

        Employee obj = new();

        public frmPrueba()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                obj.IDNumber = txtIDNumber.Text;


            }catch (ValidationExcption ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            try
            {
                obj.Firstname = txtFirstName.Text;


            }
            catch (ValidationExcption el)
            {
                MessageBox.Show(el.Message);
            }
            try
            {
                obj.LastName = txtLastName.Text;


            }
            catch (ValidationExcption el)
            {
                MessageBox.Show(el.Message);
            }


        }
    }
}
