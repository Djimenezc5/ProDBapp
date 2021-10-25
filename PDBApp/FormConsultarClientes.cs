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
    public partial class FormConsultarClientes : Form
    {
        public FormConsultarClientes()
        {
            InitializeComponent();
        }
        Datos_clientes cli = new Datos_clientes();
        Contactos_clientes con = new Contactos_clientes();
        private void bttListaClientes_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = cli.MostrarClientes();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        private void bttClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttContacto_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = con.MostrarContactos();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }
    }
}
