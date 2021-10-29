using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDBApp.Clases.EMPLEADOS;

namespace PDBApp
{
    public partial class FormEditarDatosEmpleados : Form
    {
        public FormEditarDatosEmpleados()
        {
            InitializeComponent();
            tbUsuario.Enabled = false;
        }
        EditarDatosEmpleado ede = new EditarDatosEmpleado();
        private void bttClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttAceptar_Click(object sender, EventArgs e)
        {
            ede.EdicionEmpleados(textBox2.Text, tbNombre.Text, tbApellidos.Text, tbTelCelular.Text, tbTelResidencial.Text, cbDep.SelectedItem.ToString(), tbDirRes.Text, textBox1.Text, tbUsuario.Text, tbContraseña.Text,tbPuesto.Text, "1");
            MessageBox.Show("Gestion realizada");
            textBox2.Text = "";
            tbNombre.Text = "";
            tbApellidos.Text = "";
            tbTelCelular.Text = "";
            tbTelResidencial.Text = "";
            cbDep.Text = "";
            tbDirRes.Text = "";
            textBox1.Text = "";
            tbUsuario.Text = "";
            tbContraseña.Text = "";
            tbPuesto.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            tbUsuario.Text = textBox1.Text;
        }
    }
}
