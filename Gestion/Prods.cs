using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestion;
using Personas.BE;
using Productos.BE;

namespace Gestion
{
    public partial class Prods : Form
    {
        private Personas.BE.Personas personas = new Personas.BE.Personas();
        private Productos.BE.Productos productos = new Productos.BE.Productos();
        int agr, vens, stock;

        public Prods()
        {
            InitializeComponent();
            datagridemp.DataSource = productos.DAT;
            limpiar();
        }

        public void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)&& e.KeyChar!=',')
            {
                e.Handled = true;
            }
        }

        private void btning_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona = personas.Buscar(txtdni.Text);

            if (persona.DNI != null)
            {
                lbnom.Text = persona.Nombre;
                lbap.Text = persona.Apellido;
                lbed.Text = persona.Edad.ToString();
                lbven.Text = persona.Ventas.ToString();
            }
            else
            {
                MessageBox.Show("no se encontro el dni");
            }
        }

        private void btnvolv_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        public void limpiar()
        {
            txtid.Text = "";
            txtnom.Text = "";
            txtstock.Text = "";
            txtpr.Text = "";
            txtven.Text = Convert.ToString(0);
            txtaddven.Text = "";
        }

        private void btncar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            if (txtdni.Text != "" && txtid.Text != "" && txtnom.Text != null && txtpr.Text != null && txtstock.Text != null)
            {
                producto.Id = txtid.Text;
                producto.Nombre = txtnom.Text;
                producto.Stock = Convert.ToInt32(txtstock.Text);
                producto.Precio = Convert.ToDecimal(txtpr.Text);
                producto.Vendidos = Convert.ToInt32(txtven.Text);
                productos.CargProd(producto);
                MessageBox.Show("cargado");
                limpiar();
                txtid.Focus();
            }
            else
            {
                MessageBox.Show("por favor rellene correctamente los campos y llene TODOS los campos y no olvide ingresar con un dni de empleado");
                limpiar();
                txtid.Focus();
            }
        }

        private void btnbusc_Click(object sender, EventArgs e)
        {
            txtnom.Text = "";
            txtstock.Text = "";
            txtpr.Text = "";
            txtven.Text = Convert.ToString(0);
            txtaddven.Text = "";

            Producto producto = new Producto();
            producto = productos.Buscar(txtid.Text);
            if (txtdni.TextLength >0)
            {
                if (producto.Id != null)
                {
                    txtid.Text = producto.Id;
                    txtnom.Text = producto.Nombre;
                    txtstock.Text = producto.Stock.ToString();
                    txtpr.Text = producto.Precio.ToString();
                    txtven.Text = producto.Vendidos.ToString();
                    vens = producto.Vendidos;
                    stock = producto.Stock;
                    txtid.Focus();
                    txtid.SelectAll();
                }
                else
                {
                    MessageBox.Show("No se encontro el Producto");
                    limpiar();
                    txtid.Focus();
                }
            }
            else
            {
                MessageBox.Show("debe ingresar con un dni de empleado valido para buscar");
                txtdni.Focus();
            }
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            if (txtdni.TextLength > 0)
            {
                if (txtid.Text != "" && txtnom.Text != null && txtpr.Text != null && txtstock.Text != null)
                {
                    bool est = productos.BorProd(txtid.Text);
                    btncar_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("por favor rellene correctamente los campos y llene TODOS los campos");
                    limpiar();
                    txtid.Focus();
                    agr = 0;
                    vens = 0;
                    stock = 0;
                }
            }
            else
            {
                MessageBox.Show("debe ingresar con un dni de empleado valido para buscar");
                txtdni.Focus();
            }
        }

        private void btnbor_Click(object sender, EventArgs e)
        {
            if (txtdni.TextLength > 0)
            {
                if (txtid.Text != "" && txtnom.Text != null && txtpr.Text != null && txtstock.Text != null)
                {
                    bool est = productos.BorProd(txtid.Text);
                    if (est)
                    {
                        limpiar();
                        MessageBox.Show("borrado");
                        agr = 0;
                        vens = 0;
                        stock = 0;
                    }
                    else
                    {
                        MessageBox.Show("no se ha borrado");
                        txtid.Focus();
                        txtid.SelectAll();
                    }
                }
                else
                {
                    MessageBox.Show("por favor rellene correctamente los campos y llene TODOS los campos");
                    limpiar();
                    txtid.Focus();
                }
            }
            else
            {
                MessageBox.Show("debe ingresar con un dni de empleado valido para buscar");
                txtdni.Focus();
            }
        }

        private void btnagr_Click(object sender, EventArgs e)
        {
            if (txtdni.Text != "" && txtid.Text != "" && txtnom.Text != "" && txtpr.Text.Length != 0 && txtstock.Text.Length != 0)
            {
                Producto producto = new Producto();
                agr = Convert.ToInt32(txtaddven.Text);
                if (stock>agr) 
                {
                    producto.Id = txtid.Text;
                    producto.Nombre = txtnom.Text;
                    producto.Stock = stock - agr;
                    producto.Precio = Convert.ToDecimal(txtpr.Text);
                    producto.Vendidos = vens + agr;
                    bool est = productos.BorProd(txtid.Text);
                    productos.Cargven(producto);
                    Persona persona = new Persona();
                    persona.DNI = txtdni.Text;
                    persona.Nombre = lbnom.Text;
                    persona.Apellido = lbap.Text;
                    persona.Edad = Convert.ToInt32(lbed.Text);
                    persona.Ventas = Convert.ToInt32(lbven.Text) + agr;
                    bool estado = personas.borrarper(txtdni.Text);
                    personas.CargaVen(persona);
                    MessageBox.Show("cargado");
                    limpiar();
                    txtid.Focus();
                    lbnom.Text = persona.Nombre;
                    lbap.Text = persona.Apellido;
                    lbed.Text = persona.Edad.ToString();
                    lbven.Text = persona.Ventas.ToString();

                    agr = 0;
                    vens = 0;
                    stock = 0;
                }
                else
                {
                    MessageBox.Show("el stock es insuficiente para la cantidad que se quiere vender.");
                    agr = 0;
                    vens = 0;
                    stock = 0;
                    limpiar();
                    txtid.Focus();
                }
            }
            else
            {
                MessageBox.Show("por favor rellene correctamente los campos y llene TODOS los campos y no olvide ingresar con un dni de empleado");
                limpiar();
                txtid.Focus();
            }
        }
    }
}
