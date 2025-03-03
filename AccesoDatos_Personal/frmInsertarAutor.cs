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
    public partial class frmInsertarAutor : Form
    {
        public frmInsertarAutor()
        {
            InitializeComponent();
        }

        private void btnInserta_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.cmd("INSERT INTO authors(au_id,au_fname,au_lname,phone,address,city,state,zip,contract) VALUES ('" +
                tbId.Text+"','"+
                tbFN.Text+"','"+
                tbLN.Text + "','" +
                tbPhone.Text+"','"+
                tbAddress.Text+"','"+
                tbCity.Text+"','"+
                tbZip.Text+"','"+
                (checkBox1.Checked ? 1 : 0) +"');"
            );

             
            if (f == true)
            {
                MessageBox.Show("Datos insertados", "Sistema", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error al insertar", "Sistema", MessageBoxButtons.OK);
            }
        }
    }
}
