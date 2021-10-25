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
    public partial class FormConsulta_empleados : Form
    {
        public FormConsulta_empleados()
        {
            InitializeComponent();
        }

        private void bttClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        Datos_empleado de = new Datos_empleado();
        Contacto_empleado ce = new Contacto_empleado();

        private void bttListaEmpleados_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = de.DatosEmpleados();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        private void bttContacto_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = ce.ContactoEmpleados();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }
    }
}
