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
    public partial class Login : Form
    {

        string user = "";
        string pass = "";

        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textUser.Text = "introduzca el usuario";
            textUser.ForeColor = Color.White;
            textPass.PasswordChar = '\0';
            textPass.Text = "introduzca la contraseña";
            textPass.ForeColor = Color.White;
        }

        private void textUser_Enter(object sender, EventArgs e)
        {
            textUser.Text = "";
            textUser.ForeColor = Color.Black;
        }

        private void textUser_Leave(object sender, EventArgs e)
        {
            user = textUser.Text;
            if (user.Equals("introduzca el usuario"))
            {
                textUser.Text = "introduzca el usuario";
                textUser.ForeColor = Color.White;

            }
            else
            {
                if (user.Equals(""))
                {

                    textUser.Text = "introduzca el usuario";
                    textUser.ForeColor = Color.Gray;
                }
                else
                {
                    textUser.Text = user;
                    textUser.ForeColor = Color.Black;
                }
            }
        }

        private void textPass_Enter(object sender, EventArgs e)
        {
            textPass.Text = "";
            textPass.ForeColor = Color.Black;
            textPass.PasswordChar = '*';
        }

        private void textPass_Leave(object sender, EventArgs e)
        {
            pass = textPass.Text;
            if (pass.Equals("introduzca la contraseña"))
            {
                textPass.Text = "introduzca la contraseña";
                textPass.ForeColor = Color.Gray;

            }
            else
            {
                if (pass.Equals(""))
                {
                    textPass.PasswordChar = '\0';
                    textPass.Text = "introduzca la contraseña";
                    textPass.ForeColor = Color.Gray;
                }
                else
                {
                    textPass.PasswordChar = '*';
                    textPass.Text = pass;
                    textPass.ForeColor = Color.Black;
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("el user es " + user + " y el pass es " + pass);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
