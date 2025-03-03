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
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void actualizarGrid()
        {
            Datos datos = new Datos();
            DataSet dS = datos.consulta("select\r\nemp_id as 'ID',\r\nfname as 'Nombre',\r\nminit as 'Inicial Seg. Nombre',\r\nlname as 'Apellido',\r\njob_id as 'ID Trabajador',\r\njob_lvl as 'Nivel Trabajador',\r\npub_id as 'ID Publicador',\r\nhire_date as 'Fecha de Nacimiento'\r\nfrom employee;");
            if (dS != null)
            {
                dataGridViewEmpleados.DataSource = dS.Tables[0];
            }
        }

        private void frmEmpleados_Activated(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmInsertarEmpleados fIE = new frmInsertarEmpleados();
            fIE.ShowDialog();
        }

        private void dataGridViewEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmActualizaEmpleados actualizaEmpleados = new frmActualizaEmpleados(
                    dataGridViewEmpleados[0, e.RowIndex].Value.ToString(),
                    dataGridViewEmpleados[1, e.RowIndex].Value.ToString(),
                    dataGridViewEmpleados[2, e.RowIndex].Value.ToString(),
                    dataGridViewEmpleados[3, e.RowIndex].Value.ToString(),
                    dataGridViewEmpleados[4, e.RowIndex].Value.ToString(),
                    dataGridViewEmpleados[5, e.RowIndex].Value.ToString(),
                    dataGridViewEmpleados[6, e.RowIndex].Value.ToString(),
                    dataGridViewEmpleados[7, e.RowIndex].Value.ToString()
                );
            actualizaEmpleados.ShowDialog();
        }
    }
}
