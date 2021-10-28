using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDBApp.Clases.SUCURSALES;
namespace PDBApp
{
    public partial class FormConsultaSucursal : Form
    {
        public FormConsultaSucursal()
        {
            InitializeComponent();
        }
        ConsultaSucursal cs = new ConsultaSucursal();
        ConsultarContactoSucursal ccs = new ConsultarContactoSucursal();
        Masventas mv = new Masventas();
        Menosventas mmv = new Menosventas();
        private void bttClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = cs.ConsultarDatosSucursal();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = ccs.ConsultarConSucursal();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = mv.ConsultarMasVentasSucursal();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }

        private void btttop_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = mmv.ConsultarMenosVentasSucursal();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
        }
    }
}
