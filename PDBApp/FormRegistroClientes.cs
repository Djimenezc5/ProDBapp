using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDBApp.Clases.CLIENTES;

namespace PDBApp
{
    public partial class FormRegistroClientes : Form
    {
        public FormRegistroClientes()
        {
            InitializeComponent();
        }
        AñadirCliente AC = new AñadirCliente();
        private void bttClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttAceptar_Click(object sender, EventArgs e)
        {
            AC.RegistroCliente(tbNombre.Text, tbApellidos.Text, tbTelCelular.Text, tbTelResidencial.Text, cbDep.SelectedItem.ToString(), tbDirRes.Text, tbPuesto.Text, tbNIT.Text);
            MessageBox.Show("Registro Realizado");
        }
    }
}
