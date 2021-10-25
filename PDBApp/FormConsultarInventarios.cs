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
    public partial class FormConsultarInventarios : Form
    {
        public FormConsultarInventarios()
        {
            InitializeComponent();
        }

        private void bttClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Consultas_inventarios ci = new Consultas_inventarios();
        private void btttop_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = ci.TOP10MENOR();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = ci.MenorCantidad();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = ci.MayorCantidad();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }
    }
}
