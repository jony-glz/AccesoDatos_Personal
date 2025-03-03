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
    public partial class frmActualizaAutor : Form
    {
        public frmActualizaAutor(string id, string fn, string ln, string phone, string address,
            string city, string state, string zip, bool contract)
        {
            InitializeComponent();
            tbFN.Text = fn;
            tbLN.Text = ln;
            tbPhone.Text = phone;
            tbAddress.Text = address;
            tbCity.Text = city;
            tbState.Text = state;
            tbZip.Text = zip;
            tbId.Text = id;
            checkBox1.Checked = contract;
        }

        private void btnActualiza_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.cmd("UPDATE authors SET " +
                "au_fname='" + tbFN.Text +
                "', au_lname='" + tbLN.Text +
                "', phone='" + tbPhone.Text +
                "', address='" + tbAddress.Text +
                "', city='" + tbCity.Text +
                "', state='" + tbState.Text +
                "', zip='" + tbZip.Text +
                "', contract='" + (checkBox1.Checked ? 1 : 0) +
                "' where au_id='" + tbId.Text + "';"
            );
            if (f == true)
            {
                MessageBox.Show("Datos actualizados", "Sistema", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Error al actualizar", "Sistema", MessageBoxButtons.OK);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show(
                "Seguro de borrar este registro?",
                "Sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            if (r == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.cmd("delete from authors where au_id='" + tbId.Text + "';");

                if (f == true)
                {
                    MessageBox.Show("Datos borrados", "Sistema", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Sistema", MessageBoxButtons.OK);
                }
            }
        }

    }
}
