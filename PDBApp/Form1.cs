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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }

        private void customizeDesing() 
        {
            panelClientes.Visible = false;
            panelContabilidad.Visible = false;
            panelEmpleados.Visible = false;
            panelProveedores.Visible = false;
            // Podemos agregar otras formas de personalizar el diseño
        }

        private void hideSubMenu() 
        {
            if (panelClientes.Visible == true)
            {
                panelClientes.Visible = false;
            }
            if (panelContabilidad.Visible == true)
            {
                panelContabilidad.Visible = false;
            }
            if (panelEmpleados.Visible == true)
            {
                panelEmpleados.Visible = false;
            }
            if (panelProveedores.Visible==true)
            {
                panelProveedores.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu) 
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }else
            {
                subMenu.Visible = false;   
            }
        }

        private Form activeForm = null;
        private void openChildForms(Form childForm)
    {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        #region Empleados
        private void Empleados_Click(object sender, EventArgs e)
        {
            showSubMenu(panelEmpleados);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForms(new FormConsulta_empleados());
            //Agregamos nuestro x contenido, abrir un formulario, mostrar información, hacer una consulta etc.
            hideSubMenu();
        }
        private void bttRE_Click(object sender, EventArgs e)
        {
            openChildForms(new FormRegistroEmpleados());
            //Agregamos nuestro x contenido, abrir un formulario, mostrar información, hacer una consulta etc.
            hideSubMenu();
        }
        private void bttEDE_Click(object sender, EventArgs e)
        {
            openChildForms(new FormEditarDatosEmpleados());
            //Agregamos nuestro x contenido, abrir un formulario, mostrar información, hacer una consulta etc.
            hideSubMenu();
        }
        #endregion
        #region Contabilidad
        private void Contabilidad_Click(object sender, EventArgs e)
        {
            showSubMenu(panelContabilidad);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openChildForms(new Ventas_Conta());
            //Agregamos nuestro x contenido, abrir un formulario, mostrar información, hacer una consulta etc.
            hideSubMenu();
        }
        #endregion
        #region Clientes
        private void Clientes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelClientes);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openChildForms(new FormConsultarClientes());
            //Agregamos nuestro x contenido, abrir un formulario, mostrar información, hacer una consulta etc.
            hideSubMenu();
        }
        private void bttRC_Click(object sender, EventArgs e)
        {
            openChildForms(new FormRegistroClientes());
            //Agregamos nuestro x contenido, abrir un formulario, mostrar información, hacer una consulta etc.
            hideSubMenu();
        }
        private void bttEDC_Click(object sender, EventArgs e)
        {
            openChildForms(new FormEditarDatosCliente());
            //Agregamos nuestro x contenido, abrir un formulario, mostrar información, hacer una consulta etc.
            hideSubMenu();
        }
        #endregion
        #region Proveedores
        private void Proveedores_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProveedores);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Agregamos nuestro x contenido, abrir un formulario, mostrar información, hacer una consulta etc.
            hideSubMenu();
        }
        #endregion
        #region Sucursal
        private void Sucursales_Click(object sender, EventArgs e)
        {
            //Agregamos nuestro x contenido, abrir un formulario, mostrar información, hacer una consulta etc.
            hideSubMenu();
        }
        #endregion

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            openChildForms(new Libros_Conta());
        }
    }
}
