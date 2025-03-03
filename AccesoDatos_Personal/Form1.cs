namespace AccesoDatos_Personal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.prueba();
            if (f)
            {
                MessageBox.Show("Conexion exitosa");
            } else
            {
                MessageBox.Show("Error en la conexion");
            }
        }
    }
}
