using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Program_UAS_AHMAD
{
    public partial class frmstockshirtboy : Form
    {
        string koneksi = "Provider = Microsoft.jet.oledb.4.0;Data source=" + Application.StartupPath + "/Gucci_Gang.mdb";
        DataSet ds = new DataSet();

        public frmstockshirtboy()
        {
            InitializeComponent();
        }

        private void tampil()
        {
            ds.Clear();
            string sql = "select ID,Nama_Item,harga,stok,kategori from TB_PRODUCTS where kategori='Baju Pria'";
            OleDbConnection con = new OleDbConnection(koneksi);
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);

            da.Fill(ds, "TB_PRODUCTS");
            con.Close();
            DG.DataSource = ds.Tables["TB_PRODUCTS"].DefaultView;
        }
        private void search()
        {
            ds.Clear();
            string sql = "select ID,Nama_Item,harga,stok,kategori from TB_PRODUCTS where id='" + txtid.Text + "' AND kategori='" + txtkat.Text + "'";
            OleDbConnection con = new OleDbConnection(koneksi);
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);

            da.Fill(ds, "TB_PRODUCTS");
            con.Close();
            DG.DataSource = ds.Tables["TB_PRODUCTS"].DefaultView;
        }


        private void frmstockshirtboy_Load(object sender, EventArgs e)
        {
            tampil();
            txtid.Enabled = true;
        }

        private void btdelete_Click(object sender, EventArgs e)
        {

        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tampil();
        }
    }
}
