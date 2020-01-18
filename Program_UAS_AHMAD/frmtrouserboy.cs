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
using System.IO;

namespace Program_UAS_AHMAD
{
    public partial class frmtrouserboy : Form
    {

        
        string koneksi = "Provider = Microsoft.jet.oledb.4.0;Data source=" + Application.StartupPath + "/Gucci_Gang.mdb";
        DataSet ds = new DataSet();
        OleDbCommand cmd = new OleDbCommand();


       
        public frmtrouserboy()
        {
            InitializeComponent();
        }
        private void tampil()
        {
            ds.Clear();
            string sql = "select ID,Nama_Item,harga,stok,kategori,gambar from TB_PRODUCTS where kategori='" + txtkat.Text + "'";
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
            string sql = "select ID,Nama_Item,harga,stok,kategori from TB_PRODUCTS where id='" + lblid.Text + txtid.Text + "' AND kategori='" + txtkat.Text + "'";
            OleDbConnection con = new OleDbConnection(koneksi);
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);

            da.Fill(ds, "TB_PRODUCTS");
            con.Close();
            DG.DataSource = ds.Tables["TB_PRODUCTS"].DefaultView;
        }

        private void DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmtrouserboy_Load(object sender, EventArgs e)
        {

        }

        private void btnew_Click(object sender, EventArgs e)
        {

        }
    }
}
