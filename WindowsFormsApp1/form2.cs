using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        struct Destino
        {
            public string lugarDeDestino;
            public double precio;
            public string horario;
        }
        struct Equipaje
        {
            public int numeroMaletas;
            public int valorTotal;
        }
        struct Boleto
        {
            public int asientos;
            public double valor;
            public string destino;
        }
        Equipaje maleta;
        Boleto compra;
        Destino [] lugares = new Destino [5];
        public Form2()
        {
            InitializeComponent();
            lugares[0].lugarDeDestino = "Guayaquil";
            lugares[0].precio = 4.5;
            lugares[0].horario = "13:00";
            lugares[1].lugarDeDestino = "Cuenca";
            lugares[1].precio = 5.3;
            lugares[1].horario = "15:00";
            lugares[2].lugarDeDestino = "Napo";
            lugares[2].precio = 5.3;
            lugares[2].horario = "12:00";
            lugares[3].lugarDeDestino = "Loja";
            lugares[3].precio = 4.7;
            lugares[3].horario = "18:00";
            lugares[4].lugarDeDestino = "Carchi";
            lugares[4].precio = 3.8;
            lugares[4].horario = "17:00";
            cmbDestinos.Items.Add(lugares[0].lugarDeDestino);
            cmbDestinos.Items.Add(lugares[1].lugarDeDestino);
            cmbDestinos.Items.Add(lugares[2].lugarDeDestino);
            cmbDestinos.Items.Add(lugares[3].lugarDeDestino);
            cmbDestinos.Items.Add(lugares[4].lugarDeDestino);
            for (int i=0; i<5; i++)
            {
                ListViewItem items = new ListViewItem();
                items = lstLugares.Items.Add(lugares[i].lugarDeDestino);
                items.SubItems.Add(lugares[i].precio.ToString());
                items.SubItems.Add(lugares[i].horario);
            }
        }

        private void rbtSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtSi.Checked)
            {
                lblCantidad.Visible = true;
                txtCantidad.Visible = true;
            }
            else
            {
                lblCantidad.Visible = false;
                txtCantidad.Visible = false;
            }
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            llenarDatos();
            
        }

        public void limpiarDatos()
        {
            txtBoletos.Text = null;
            txtCantidad.Text = null;
        }
        public void llenarDatos()
        {

            if (cmbDestinos.SelectedIndex > 0)
            {
                compra.destino = cmbDestinos.Text;
                try
                {
                    compra.asientos = Convert.ToInt16(txtBoletos.Text);
                } catch (NullReferenceException)
                {
                    lblMensaje.Visible = true;
                }
                
            }
            if (rbtSi.Checked)
            {
                maleta.numeroMaletas = int.Parse(txtCantidad.Text);
            }
            
        }

      
    }
}
