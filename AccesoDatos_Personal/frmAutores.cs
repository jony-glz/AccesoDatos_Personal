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
    public partial class frmAutores : Form
    {
        public frmAutores()
        {
            InitializeComponent();
        }

        private void frmAutores_Load(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void dataGridViewAutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActualizaAutor actualizaAutor = new frmActualizaAutor(
                    dataGridViewAutores[0, e.RowIndex].Value.ToString(),
                    dataGridViewAutores[1, e.RowIndex].Value.ToString(),
                    dataGridViewAutores[2, e.RowIndex].Value.ToString(),
                    dataGridViewAutores[3, e.RowIndex].Value.ToString(),
                    dataGridViewAutores[4, e.RowIndex].Value.ToString(),
                    dataGridViewAutores[5, e.RowIndex].Value.ToString(),
                    dataGridViewAutores[6, e.RowIndex].Value.ToString(),
                    dataGridViewAutores[7, e.RowIndex].Value.ToString(),
                    Convert.ToBoolean(dataGridViewAutores[8, dataGridViewAutores.CurrentRow.Index].Value)
                );
            actualizaAutor.ShowDialog();
        }

        private void frmAutores_Activated(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void actualizarGrid()
        {
            Datos datos = new Datos();
            DataSet dS = datos.consulta("SELECT au_id as 'ID', au_fname as 'Nombre', au_lname as 'Apellidos', phone as 'Telefono', address as 'Direccion', city as 'Ciudad', state as 'Estado', zip as 'CP', contract as 'Contratado' FROM authors");
            if (dS != null)
            {
                dataGridViewAutores.DataSource = dS.Tables[0];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmInsertarAutor insertarAutor = new frmInsertarAutor();
            insertarAutor.ShowDialog();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados emp = new frmEmpleados();
            emp.ShowDialog();
        }

        private void títulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTitulos t = new frmTitulos();
            t.ShowDialog();
        }
    }
}
