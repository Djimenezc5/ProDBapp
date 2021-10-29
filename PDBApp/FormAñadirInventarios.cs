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
    public partial class FormAñadirInventarios : Form
    {
        public FormAñadirInventarios()
        {
            InitializeComponent();
        }
        LlenadoInventario LI = new LlenadoInventario();
        private void bttClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttAceptar_Click(object sender, EventArgs e)
        {
            LI.LlenadoInven(textBox1.Text,comboBox1.SelectedItem.ToString(), dateTimePicker1.Value.ToString(), tbCantidad.Text);
            MessageBox.Show("Asignación realizada");
            textBox1.Text = "";
            comboBox1.Text = "";
            tbCantidad.Text = "";
        }
    }
}
