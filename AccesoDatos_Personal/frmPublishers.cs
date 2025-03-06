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
    public partial class frmPublishers : Form
    {
        public frmPublishers()
        {
            InitializeComponent();
        }

        private void actualizarGrid()
        {
            Datos datos = new Datos();
            DataSet dS = datos.consulta("select pub_id as 'ID', pub_name as 'Name', city as 'City', state as 'State', country as 'Country' from publishers;");
            if (dS != null)
            {
                dataGridViewEditorial.DataSource = dS.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmPublishers_Load(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void frmPublishers_Activated(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void dataGridViewEditorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            actualizarGrid();
        }
    }
}
