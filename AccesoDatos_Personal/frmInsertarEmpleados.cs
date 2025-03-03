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
    public partial class frmInsertarEmpleados : Form
    {
        public frmInsertarEmpleados()
        {
            InitializeComponent();
        }

        private void btnInserta_Click(object sender, EventArgs e)
        {
            string id = tbId.Text;
            string fname = tbFN.Text;
            string minit = tbMinit.Text;
            string lname = tbLN.Text;
            string jobid = tbIDJob.Text;
            string lvjob = tbLVJob.Text;
            string idpub = tbIDPub.Text;
            string hiredate = dtpHireDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

            Datos datos = new Datos();
            bool f = datos.cmd("insert into employee(emp_id,fname,lname,minit,job_id,job_lvl,pub_id,hire_date)"
                +"values ('" + id + "','"+fname+"','"+lname+"','"+minit+"','"+jobid+"','"+lvjob+"','"+idpub+"','"+hiredate+"');");

            if (f)
            {
                MessageBox.Show("Datos insertados", "Sistema", MessageBoxButtons.OK,MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Error al insertar", "Sistema", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
