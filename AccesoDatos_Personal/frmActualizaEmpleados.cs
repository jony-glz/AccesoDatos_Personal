using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoDatos_Personal
{
    public partial class frmActualizaEmpleados : Form
    {

        public frmActualizaEmpleados(string id, string fname, string minit, string lname, string idjob, string lvljob, string idpub, string hiredate)
        {
            InitializeComponent();
            tbId.Text = id;
            tbFN.Text = fname;
            tbLN.Text = lname;
            tbMinit.Text = minit;
            tbIDJob.Text = idjob;
            tbIDPub.Text = idpub;
            tbLVJob.Text = lvljob;
            dtpHireDate.Text = hiredate;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            string id = tbId.Text;

            DialogResult r = MessageBox.Show("Seguro que quieres eliminar?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.cmd("delete from employee where emp_id='" + id + "';");
                if (f)
                {
                    MessageBox.Show("Registro eliminado", "Sistema", MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = tbId.Text;
            string lname = tbLN.Text;
            string fname = tbFN.Text;
            string minit = tbMinit.Text;
            string idjob = tbIDJob.Text;
            string lvljob = tbLVJob.Text;
            string idpub = tbIDPub.Text;
            string date = dtpHireDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

            Datos datos = new Datos();
            Boolean f = datos.cmd("UPDATE employee SET " +
                 "fname='" + fname + "', " +
                "lname='" + lname + "', " +
                "minit='" + minit + "', " +
                "job_id='" + idjob + "', " +
                "job_lvl='" + lvljob + "', " +
                "pub_id='" + idpub + "', " +
                "hire_date='" + date + "' " +
                "WHERE emp_id='" + id + "';"
            );

            if (f)
            {
                MessageBox.Show("Registro actualizado", "Sistema", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Error al actualizar", "Sistema", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }
    }
}
