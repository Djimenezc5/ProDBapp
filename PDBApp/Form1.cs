using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDBApp.Clases;

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
            tbIDfac.Enabled = false;
            tbIDfacDet.Enabled = false;
            tbPrecio.Enabled = false; 
            cbIDProd.Enabled = false;
            cbIDtipopago.Enabled = false;
            tbPrecio.Enabled = false;
            bttAceptarD.Enabled = false;
            bttNF.Enabled = false;
        }
        InsertarFactura IF = new InsertarFactura();
        InsertarDetalleFactura IDF = new InsertarDetalleFactura();
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
        private void bttAceptar_Click(object sender, EventArgs e)
        {
            cbIDProd.Enabled = true;
            cbIDtipopago.Enabled = true;
            tbPrecio.Enabled = true;
            bttAceptarD.Enabled = true;
            string id_fac = IF.Factura(cbSucursal.SelectedItem.ToString(), tbIDEmpleado.Text, tbIDCliente.Text, Convert.ToString(dateTimePicker1.Value), "0.00");
            tbIDfac.Text = id_fac;        
            tbIDfacDet.Text = id_fac;
            MessageBox.Show("Encabezado creado");
            cbSucursal.Enabled = false;
            tbIDEmpleado.Enabled = false;
            tbIDCliente.Enabled = false;
            dateTimePicker1.Enabled = false;
            bttAceptar.Enabled = false;
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
        private void button5_Click(object sender, EventArgs e)
        {
            openChildForms(new FormAñadirInventarios());
            hideSubMenu();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            openChildForms(new FormAñadirProducto());
            hideSubMenu();
        }
        private void bttEditProd_Click(object sender, EventArgs e)
        {
            openChildForms(new FormEditarDatosProductos());
            hideSubMenu();
        }
        private void bttConsultaInventario_Click(object sender, EventArgs e)
        {
            openChildForms(new FormConsultarInventarios());
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
            openChildForms(new Consulta_proveedores());
            //Agregamos nuestro x contenido, abrir un formulario, mostrar información, hacer una consulta etc.
            hideSubMenu();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            openChildForms(new Actualizacion_proveedores());
            hideSubMenu();
        }
        #endregion
        #region Sucursal
        private void Sucursales_Click(object sender, EventArgs e)
        {
            openChildForms(new FormConsultaSucursal());
            //Agregamos nuestro x contenido, abrir un formulario, mostrar información, hacer una consulta etc.
            hideSubMenu();
        }
        #endregion

        private void cbIDProd_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string precio = IDF.Consulta_precio(cbIDProd.SelectedItem.ToString());
            tbPrecio.Text = "";
            tbPrecio.Text = precio.ToString();
        }

        private void bttAceptarD_Click(object sender, EventArgs e)
        {
            IDF.Detalle_Factura(tbIDfacDet.Text, cbIDProd.SelectedItem.ToString(), cbIDtipopago.SelectedItem.ToString(),tbCantidad.Text,tbPrecio.Text);
            dataGridView1.DataSource = IDF.MostrarFactura(tbIDfacDet.Text);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            cbIDProd.Text = "";
            cbIDtipopago.Text = "";
            tbCantidad.Text = "";
            tbPrecio.Text = "";
            bttNF.Enabled = true;
        }

        private void bttNF_Click(object sender, EventArgs e)
        {
            cbIDProd.Text = "";
            cbIDtipopago.Text = "";
            tbCantidad.Text = "";
            tbPrecio.Text = "";
            tbIDfac.Text = "";
            tbIDfacDet.Text = "";
            tbIDEmpleado.Text = "";
            tbIDCliente.Text = "";
            cbSucursal.Text = "";

            cbSucursal.Enabled = true;
            tbIDEmpleado.Enabled = true;
            tbIDCliente.Enabled = true;
            dateTimePicker1.Enabled = true;
            bttAceptar.Enabled = true;
   
            cbIDProd.Enabled = false;
            cbIDtipopago.Enabled = false;
            bttAceptarD.Enabled = false;
            bttNF.Enabled = false;

            dataGridView1.Columns.Clear();
        }
    }
}
