using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projecto_s
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


      
       
        public void controlNombre()
        {
            if (txtName.Text.Trim() != string.Empty && txtName.Text.All(char.IsLetter))
            {
                btnContinuar.Enabled = true;
                errorProvider1.SetError(txtName, "");
            }
            else
            {
                if (!(txtName.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(txtName, "El nombre debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(txtName, "Debe introducir su nombre");

                }
                btnContinuar.Enabled = false;
                txtName.Focus();
            }
        }
        private void controlApellido()
        {
            if (txtApellido.Text.Trim() != string.Empty && txtApellido.Text.All(char.IsLetter))
            {
                btnContinuar.Enabled = true;
                errorProvider1.SetError(txtApellido, "");
            }
            else
            {
                if (!(txtApellido.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(txtApellido, "El nombre debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(txtApellido, "Debe introducir su nombre");

                }
                btnContinuar.Enabled = false;
                txtApellido.Focus();
            }
        }
        private void controlCedula()
        {
            if (txtCedula.Text.Trim() != string.Empty && txtCedula.Text.All(char.IsNumber))
            {
                btnContinuar.Enabled = true;
                errorProvider1.SetError(txtCedula, "");
            }
            else
            {
                if (!(txtCedula.Text.All(Char.IsNumber)))
                {
                    errorProvider1.SetError(txtCedula, "El nombre debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(txtCedula, "Debe introducir su nombre");

                }
                btnContinuar.Enabled = false;
                txtCedula.Focus();
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            borrarDatos(); // llamo a la función borrar datos


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnContinuar.Enabled = false;
        }

        private void lblDestino_Click(object sender, EventArgs e)
        {

        }
        public void borrarDatos()
        {
            txtName.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            controlNombre();
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {
            controlCedula();
        }

        private void txtApellido_TextChanged_1(object sender, EventArgs e)
        {
            controlApellido();
        }
    }
}
