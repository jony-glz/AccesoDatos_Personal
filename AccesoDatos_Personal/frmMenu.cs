using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos_Personal
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutores autor = new frmAutores();
            autor.Show();

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados empleados = new frmEmpleados();
            empleados.Show();
        }

        private void títulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTitulos titulos = new frmTitulos();
            titulos.Show();
        }

        private void editorialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPublishers publishers = new frmPublishers();
            publishers.Show();
        }
    }
}
