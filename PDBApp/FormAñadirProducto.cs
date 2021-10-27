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
    public partial class FormAñadirProducto : Form
    {
        public FormAñadirProducto()
        {
            InitializeComponent();
        }
        AñadirProducto AP = new AñadirProducto();
        private void bttClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttAceptar_Click(object sender, EventArgs e)
        {
            AP.LlenadoProducto(textBox1.Text, cbIDproveedo.SelectedItem.ToString(), textBox2.Text, tbNombre.Text, tbDescProd.Text, cbEstatus.SelectedItem.ToString());
            MessageBox.Show("Asignación realizada");
        }
    }
}
