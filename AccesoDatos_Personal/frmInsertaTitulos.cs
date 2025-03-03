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
    public partial class frmInsertaTitulos : Form
    {
        public frmInsertaTitulos()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string id = tbId.Text, Name = tbName.Text, type = tbType.Text, pub_id = tbPubId.Text,
                price = tbPrice.Text, advance = tbAdvance.Text, royalty = tbRoyalty.Text,
                ytd_sales = tbYTDSales.Text, notes = rtbNotes.Text, date = dtpDate.Value.ToString("yyyy-MM-dd HH:mm:ss");

            Datos datos = new Datos();
            Boolean f = datos.cmd("" +
                "INSERT INTO titles(title_id,title,type,pub_id,price,advance,royalty,ytd_sales,notes,pubdate) VALUES" +
                "('" + id + "','" + Name + "','" + type + "','" + pub_id + "','" + price + "','" + advance + "','" + royalty + "'," +
                "'" + ytd_sales + "','"+notes+"','"+date+"')");
            if (f == true)
            {
                MessageBox.Show("Se han insertado los datos", "Sistema", MessageBoxButtons.OK,MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Error al insertar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
