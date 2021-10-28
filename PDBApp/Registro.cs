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
    public partial class Registro : Form
    {
        string Nombre = "";
        string Apellido = "";
        string Celular = "";
        string Telefono_casa = "";
        string Direccion = "";
        string Correo = "";
        string Departamento = "";
        string Contraseña = "";
        string Confirm_contra = "";
        string Puesto = "";

        public Registro()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Registro_Load(object sender, EventArgs e)
        {
            textNombre.Text = "Introduzca Nombre";
            textNombre.ForeColor = Color.White;

            textApellido.Text = "Introduzca Apellido";
            textApellido.ForeColor = Color.White;

            textCelular.Text = "Introduzca Numero de Movil";
            textCelular.ForeColor = Color.White;

            textTelefono_casa.Text = "Introduzca Telefono de Casa";
            textTelefono_casa.ForeColor = Color.White;

            textDireccion.Text = "Introduzca Direccion";
            textDireccion.ForeColor = Color.White;

            textDepartamento.Text = "Introduzca Id Departamento";
            textDepartamento.ForeColor = Color.White;

            textContraseña.Text = "Introduzca Contraseña";
            textContraseña.ForeColor = Color.White;

            textConfirm_contra.Text = "Introduzca Nuevamente la Contraseña";
            textConfirm_contra.ForeColor = Color.White;

            textPuesto.Text = "Introduzca Puesto de trabajo";
            textPuesto.ForeColor = Color.White;
        }
    }
}
