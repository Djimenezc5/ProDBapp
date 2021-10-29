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
        NuevoEmpleado ne = new NuevoEmpleado();

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

            textTelefono_casa.Text = "Introduzca Numero de Telefono de Casa";
            textTelefono_casa.ForeColor = Color.White;

            textDireccion.Text = "Introduzca Direccion";
            textDireccion.ForeColor = Color.White;

            textCorreo.Text = "Introduzca Correo electronico (Tambien sera su usuario)";
            textCorreo.ForeColor = Color.White;

            textDepartamento.Text = "Introduzca Id Departamento";
            textDepartamento.ForeColor = Color.White;

            textContraseña.Text = "Introduzca Contraseña";
            textContraseña.ForeColor = Color.White;

            textConfirm_contra.Text = "Introduzca Nuevamente la Contraseña";
            textConfirm_contra.ForeColor = Color.White;

            textPuesto.Text = "Introduzca Puesto de trabajo";
            textPuesto.ForeColor = Color.White;
        }

        private void textNombre_Enter(object sender, EventArgs e)
        {
            textNombre.Text = "";
            textNombre.ForeColor = Color.Black;
        }

        private void textNombre_Leave(object sender, EventArgs e)
        {
            Nombre = textNombre.Text;
            if (Nombre.Equals("Introduzca Nombre"))
            {
                textNombre.Text = "Introduzca Nombre";
                textNombre.ForeColor = Color.White;
            }
            else
            {
                if (Nombre.Equals(""))
                {
                    textNombre.Text = "Introduzca Nombre";
                    textNombre.ForeColor = Color.White;
                }
                else
                {
                    textNombre.Text = Nombre;
                    textNombre.ForeColor = Color.Black;
                }
            }

        }

        private void textApellido_Enter(object sender, EventArgs e)
        {
            textApellido.Text = "";
            textApellido.ForeColor = Color.Black;
        }

        private void textApellido_Leave(object sender, EventArgs e)
        {
            Apellido = textApellido.Text;
            if (Apellido.Equals("Introduzca Apellido"))
            {
                textApellido.Text = "Introduzca Apellido";
                textApellido.ForeColor = Color.White;
            }
            else
            {
                if (Apellido.Equals(""))
                {
                    textApellido.Text = "Introduzca Apellido";
                    textApellido.ForeColor = Color.White;
                }
                else
                {
                    textApellido.Text = Apellido;
                    textApellido.ForeColor = Color.Black;
                }
            }
        }

        private void textCelular_Enter(object sender, EventArgs e)
        {
            textCelular.Text = "";
            textCelular.ForeColor = Color.Black;
        }

        private void textCelular_Leave(object sender, EventArgs e)
        {
            Celular = textCelular.Text;
            if (Celular.Equals("Introduzca Numero de Celular"))
            {
                textCelular.Text = "Introduzca Numero de Celular";
                textCelular.ForeColor = Color.White;
            }
            else
            {
                if (Celular.Equals(""))
                {
                    textCelular.Text = "Introduzca Numero de Celular";
                    textCelular.ForeColor = Color.White;
                }
                else
                {
                    textCelular.Text = Celular;
                    textCelular.ForeColor = Color.Black;
                }
            }
        }

        private void textTelefono_casa_Enter(object sender, EventArgs e)
        {
            textTelefono_casa.Text = "";
            textTelefono_casa.ForeColor = Color.Black;
        }

        private void textTelefono_casa_Leave(object sender, EventArgs e)
        {
            Telefono_casa = textTelefono_casa.Text;
            if (Telefono_casa.Equals("Introduzca Numero de Telefono de Casa"))
            {
                textTelefono_casa.Text = "Introduzca Numero de Telefono de Casa";
                textTelefono_casa.ForeColor = Color.White;
            }
            else
            {
                if (Telefono_casa.Equals(""))
                {
                    textTelefono_casa.Text = "Introduzca Numero de Celular";
                    textTelefono_casa.ForeColor = Color.White;
                }
                else
                {
                    textTelefono_casa.Text = Telefono_casa;
                    textTelefono_casa.ForeColor = Color.Black;
                }
            }
        }

        private void textDireccion_Enter(object sender, EventArgs e)
        {
            textDireccion.Text = "";
            textDireccion.ForeColor = Color.Black;
        }

        private void textDireccion_Leave(object sender, EventArgs e)
        {
            Direccion = textDireccion.Text;
            if (Direccion.Equals("Introduzca Direccion"))
            {
                textDireccion.Text = "Introduzca Direccion";
                textDireccion.ForeColor = Color.White;
            }
            else
            {
                if (Direccion.Equals(""))
                {
                    textDireccion.Text = "Introduzca Direccion";
                    textDireccion.ForeColor = Color.White;
                }
                else
                {
                    textDireccion.Text = Direccion;
                    textDireccion.ForeColor = Color.Black;
                }
            }
        }

        private void textCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textCorreo_Enter(object sender, EventArgs e)
        {
            textCorreo.Text = "";
            textCorreo.ForeColor = Color.Black;
        }

        private void textCorreo_Leave(object sender, EventArgs e)
        {
            Correo = textCorreo.Text;
            if (Correo.Equals("Introduzca Correo Electronico (Tambien sera su usuario)"))
            {
                textCorreo.Text = "Introduzca Correo Electronico (Tambien sera su usuario)";
                textCorreo.ForeColor = Color.White;
            }
            else
            {
                if (Correo.Equals(""))
                {
                    textCorreo.Text = "Introduzca Correo Electronico (Tambien sera su usuario)";
                    textCorreo.ForeColor = Color.White;
                }
                else
                {
                    textCorreo.Text = Correo;
                    textCorreo.ForeColor = Color.Black;
                }
            }
        }

        private void textDepartamento_Enter(object sender, EventArgs e)
        {
            textDepartamento.Text = "";
            textDepartamento.ForeColor = Color.Black;
        }

        private void textDepartamento_Leave(object sender, EventArgs e)
        {
            Departamento = textDepartamento.Text;
            if (Departamento.Equals("Introduzca Departamento"))
            {
                textDepartamento.Text = "Introduzca Departamento";
                textDepartamento.ForeColor = Color.White;
            }
            else
            {
                if (Departamento.Equals(""))
                {
                    textDepartamento.Text = "Introduzca Departamento";
                    textDepartamento.ForeColor = Color.White;
                }
                else
                {
                    textDepartamento.Text = Departamento;
                    textDepartamento.ForeColor = Color.Black;
                }
            }
        }

        private void textContraseña_Enter(object sender, EventArgs e)
        {
            textContraseña.Text = "";
            textContraseña.ForeColor = Color.Black;
        }

        private void textContraseña_Leave(object sender, EventArgs e)
        {
            Contraseña = textContraseña.Text;
            if (Contraseña.Equals("Introduzca Contraseña"))
            {
                textContraseña.Text = "Introduzca Contraseña";
                textContraseña.ForeColor = Color.White;
            }
            else
            {
                if (Contraseña.Equals(""))
                {
                    textContraseña.Text = "Introduzca Contraseña";
                    textContraseña.ForeColor = Color.White;
                }
                else
                {
                    textContraseña.Text = Contraseña;
                    textContraseña.ForeColor = Color.Black;
                }
            }
        }

        private void textConfirm_contra_Enter(object sender, EventArgs e)
        {
            textConfirm_contra.Text = "";
            textConfirm_contra.ForeColor = Color.Black;
        }

        private void textConfirm_contra_Leave(object sender, EventArgs e)
        {
            Confirm_contra = textConfirm_contra.Text;
            if (Confirm_contra.Equals("Introduzca Nuevamente la Contraseña"))
            {
                textConfirm_contra.Text = "Introduzca Nuevamente la Contraseña";
                textConfirm_contra.ForeColor = Color.White;
            }
            else
            {
                if (Confirm_contra.Equals(""))
                {
                    textConfirm_contra.Text = "Introduzca Nuevamente la Contraseña";
                    textConfirm_contra.ForeColor = Color.White;
                }
                else
                {
                    textConfirm_contra.Text = Confirm_contra;
                    textConfirm_contra.ForeColor = Color.Black;
                }
            }
        }

        private void textPuesto_Enter(object sender, EventArgs e)
        {
            textPuesto.Text = "";
            textPuesto.ForeColor = Color.Black;
        }

        private void textPuesto_Leave(object sender, EventArgs e)
        {
            Puesto = textPuesto.Text;
            if (Puesto.Equals("Introduzca Puesto"))
            {
                textPuesto.Text = "Introduzca Puesto";
                textPuesto.ForeColor = Color.White;
            }
            else
            {
                if (Puesto.Equals(""))
                {
                    textPuesto.Text = "Introduzca Puesto";
                    textPuesto.ForeColor = Color.White;
                }
                else
                {
                    textPuesto.Text = Puesto;
                    textPuesto.ForeColor = Color.Black;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string con = "";
            if (textContraseña.Text == textConfirm_contra.Text)
            {
                con = textContraseña.Text;
                ne.EdicionEmpleados(textNombre.Text, textApellido.Text, textCelular.Text, textTelefono_casa.Text, textDepartamento.Text, textDireccion.Text, textCorreo.Text, textCorreo.Text, con, textPuesto.Text, "1");
                Form1 f1 = new Form1();
                this.Hide();
                f1.Show();
            }
            else
            {
                MessageBox.Show("La contraseña no coincide");
                textContraseña.ForeColor = Color.Red;
                textConfirm_contra.ForeColor = Color.Red;
            }
        }
    }
}
