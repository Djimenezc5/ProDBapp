using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
