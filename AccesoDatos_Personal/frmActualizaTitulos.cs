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
    public partial class frmActualizaTitulos : Form
    {
        public frmActualizaTitulos(string id, string title, string type, string pub_id, string price, string advance, string royalty, string ytd_sales, string notes, string pubdate)
        {
            InitializeComponent();
            tbId.Text = id;
            tbName.Text = title;
            tbType.Text = type;
            tbPubId.Text = pub_id;
            tbPrice.Text = price;
            tbAdvance.Text = advance;
            tbRoyalty.Text = royalty;
            tbYTDSales.Text = ytd_sales;
            rtbNotes.Text = notes;
            dtpDate.Text = pubdate;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Deseaes eliminar?", "Sistema", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Datos datos = new Datos();
                string id = tbId.Text;
                Boolean f = datos.cmd("DELETE FROM TITLES WHERE title_id='" + id + "';");
                if (f == true)
                {
                    MessageBox.Show("Registro eliminado", "Sistema", MessageBoxButtons.OKCancel);
                }
                else
                {
                    MessageBox.Show("Registro eliminado", "Sistema", MessageBoxButtons.OKCancel);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string id = tbId.Text, name = tbName.Text, type = tbType.Text, pub_id = tbPubId.Text,
                price = tbPrice.Text, advance = tbAdvance.Text, ytd_sales = tbYTDSales.Text, notes = rtbNotes.Text
                , pubate = dtpDate.Value.ToString("yyyy-MM-dd HH:mm:ss"), royalty = tbRoyalty.Text;

            Datos datos = new Datos();
            bool f = datos.cmd("UPDATE titles SET " +
               "title='" + name + "', " +
               "type='" + type + "', " +
               "pub_id='" + pub_id + "', " +
               "price=" + price + ", " +
               "advance=" + advance + ", " +
               "royalty=" + royalty + ", " +
               "ytd_sales=" + ytd_sales + ", " +
               "notes='" + notes + "', " +
               "pubdate='" + pubate + "' " +
               "WHERE title_id='" + id + "'"
            );

            if ( f==true )
            {
                MessageBox.Show("Se han actualizado los datos", "Sistema", MessageBoxButtons.OK,MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Error al actualizar los datos", "Sistema", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
