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
using PDBApp.Clases.SUCURSALES;

namespace PDBApp
{
    public partial class Ventas_Conta : Form
    {
        public Ventas_Conta()
        {
            InitializeComponent();
        }
        Ventasxproducto vpp = new Ventasxproducto();
        Masventas mv = new Masventas();
        Ventasxtiempo vt = new Ventasxtiempo();
        private void bttClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = mv.ConsultarMasVentasSucursal();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = vpp.Ventasporproducto();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        private void btttop_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = vt.Ventaspordia();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = vt.Ventaspormes();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = vt.Ventasporaño();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }
    }
}
