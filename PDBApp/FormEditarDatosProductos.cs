using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDBApp.Clases.VENTAS__INVENTARIOS_Y_PRODUCTOS;

namespace PDBApp
{
    public partial class FormEditarDatosProductos : Form
    {
        public FormEditarDatosProductos()
        {
            InitializeComponent();
        }
        EdicionProducto ep = new EdicionProducto();
        private void bttClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttAceptar_Click(object sender, EventArgs e)
        {
            ep.EditProd(cbIDprod.SelectedItem.ToString(), cbIDproveedo.SelectedItem.ToString(), tbPrecio.Text, tbNombre.Text, tbDescProd.Text, cbEstatus.Text);
            MessageBox.Show("Gestion realizada");
            cbIDprod.Text = "";
            cbIDproveedo.Text = "";
            tbPrecio.Text = "";
            tbNombre.Text = "";
            tbDescProd.Text = "";
            cbEstatus.Text = "";
        }
    }
}
