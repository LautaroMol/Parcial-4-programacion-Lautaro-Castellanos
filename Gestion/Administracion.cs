using Personas.BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion
{
    public partial class Administracion : Form
    {

        private Personas.BE.Personas personas = new Personas.BE.Personas();

        public Administracion()
        {
            InitializeComponent();
            datagridemp.DataSource = personas.DT;
            LimpiarPantalla();
        }

        private void LimpiarPantalla()
        {
            txtdni.Text = "";
            txtnom.Text = "";
            txtap.Text = "";
            txtedad.Text = "";

            txtdni.Focus();
        }
        public void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtedad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnvolv_click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btncarga_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            if (txtdni != null && txtnom.Text.Length > 2 && txtap.Text.Length > 2 && txtedad.Text.Length > 1) 
            {
                persona.DNI = txtdni.Text;
                persona.Nombre = txtnom.Text;
                persona.Apellido = txtap.Text;
                persona.Edad = Convert.ToInt32(txtedad.Text);
                persona.Ventas = 0;

                personas.CargaEmp(persona);
                MessageBox.Show("cargado");
                LimpiarPantalla();
                txtdni.Focus();
            }
            else
            {
                MessageBox.Show("por favor rellene correctamente los campos y llene TODOS los campos");
                LimpiarPantalla();
                txtdni.Focus();
            }
        }

        private void btnbusc_Click(object sender, EventArgs e)
        {
            txtnom.Text = "";
            txtedad.Text = "";
            txtap.Text = "";
            nven.Text = "";

            Persona persona = new Persona();
            persona = personas.Buscar(txtdni.Text);

            if (persona.DNI != null)
            {
                txtdni.Text = persona.DNI;
                txtnom.Text = persona.Nombre;
                txtap.Text = persona.Apellido;
                txtedad.Text = persona.Edad.ToString();
                nven.Text = persona.Ventas.ToString();
                txtdni.Focus();
                txtdni.SelectAll();
            }
            else
            {
                MessageBox.Show("no se encontro el empleado");
                txtdni.Focus();
                txtdni.SelectAll();
            }
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            if (txtdni != null && txtnom.Text.Length > 2 && txtap.Text.Length > 2 && txtedad.Text.Length > 1)
            {
                bool est = personas.borrarper(txtdni.Text);
                btncarga_Click(sender, e);
            }
            else
            {
                MessageBox.Show("rellene todos los campos correctamente");
            }
                

        }

        private void btnbor_Click(object sender, EventArgs e)
        {
            bool estado = personas.borrarper(txtdni.Text);

            if(estado)
            {
                LimpiarPantalla();
                MessageBox.Show("borrado");
            }
            else
            {
                MessageBox.Show("no se ha borrado");
                txtdni.Focus();
                txtdni.SelectAll();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();

            if (txtdni != null && txtnom.Text.Length > 2 && txtap.Text.Length > 2 && txtedad.Text.Length > 1 && nven.Text.Length > 0)
            {
                persona.DNI = txtdni.Text;
                persona.Nombre = txtnom.Text;
                persona.Apellido = txtap.Text;
                persona.Edad = Convert.ToInt32(txtedad.Text);
                persona.Ventas = persona.Ventas + Convert.ToInt32(nven.Text);
                personas.CargaEmp(persona);

                MessageBox.Show("cargado");
                LimpiarPantalla();
                txtdni.Focus();
            }
            else
            {
                MessageBox.Show("por favor rellene correctamente los campos y llene TODOS los campos");
                LimpiarPantalla();
                txtdni.Focus();
            }
        }
    }
    
}
