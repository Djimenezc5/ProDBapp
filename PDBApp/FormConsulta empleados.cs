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
        Ventasempleados ve = new Ventasempleados();
        TopMasVentas tmv = new TopMasVentas();
        TopMenosVentas tmmv = new TopMenosVentas();

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

        private void bttVentasEmpleados_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = ve.VentasEmpleados();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        private void btttop_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = tmv.TopMasVentasEm();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = tmmv.TopMenosVentasEm();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }
    }
}
