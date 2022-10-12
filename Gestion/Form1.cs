namespace Gestion

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            this.Hide();
            Administracion administracion = new Administracion();
            administracion.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prods productos = new Prods();
            productos.Show();
        }
    }
}