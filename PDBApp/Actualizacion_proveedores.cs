using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDBApp.Clases.PROVEEDORES;

namespace PDBApp
{
    public partial class Actualizacion_proveedores : Form
    {
        public Actualizacion_proveedores()
        {
            InitializeComponent();
        }
        EditarProveedor ep = new EditarProveedor();
        private void bttClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttAceptar_Click(object sender, EventArgs e)
        {
            ep.EditProd(tbIdprov.Text, tbNombre.Text, cbDep.SelectedItem.ToString(), tbDir.Text, tbTel.Text, tbCorreo.Text, "1");
            MessageBox.Show("Gestion realizada");
        }
    }
}
