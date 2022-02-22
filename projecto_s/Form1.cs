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
    public struct Persona
    {
         string nombre;
        string apellido;
        string cedula;

    }

    public struct Boleto
    {
        Persona nombre;
        Persona apellido;
        double precio;
        string destino;
        string hora;
    }
    public struct Destino
    {
        string lugarViaje;
        int numeroDeAsientos;
    }

    public struct Equipaje
    {
        int numeroDemaletas;
        double pesoMaletas;
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void controlNombre()
        {
            if (lblNombre.Text.Trim() != string.Empty && lblNombre.Text.All(char.IsLetter))
            {
                btnContinuar.Enabled = true;
                errorProvider1.SetError(lblNombre, "");
            }
            else
            {
                if (!(lblNombre.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(lblNombre, "El nombre debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(lblNombre, "Debe introducir su nombre");

                }
                btnContinuar.Enabled = false;
                lblNombre.Focus();
            }
        }
        private void controlApellido()
        {
            if (lblApellido.Text.Trim() != string.Empty && lblApellido.Text.All(char.IsLetter))
            {
                btnContinuar.Enabled = true;
                errorProvider1.SetError(lblApellido, "");
            }
            else
            {
                if (!(lblApellido.Text.All(Char.IsLetter)))
                {
                    errorProvider1.SetError(lblApellido, "El nombre debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(lblApellido, "Debe introducir su nombre");

                }
                btnContinuar.Enabled = false;
                lblApellido.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            controlNombre();
            controlApellido();
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
            txtApellido.Clear();
            txtNombre.Clear();
            txtCI.Clear();
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
