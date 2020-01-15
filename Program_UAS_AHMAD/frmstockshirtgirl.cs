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
    public partial class frmstockshirtgirl : Form
    {
        string koneksi = "Provider = Microsoft.jet.oledb.4.0;Data source=" + Application.StartupPath + "/Gucci_Gang.mdb";
        DataSet ds = new DataSet();
        double grandstok, stok;
        public frmstockshirtgirl()
        {
            InitializeComponent();
        }

        private void tampil()
        {
            ds.Clear();
            string sql = "select ID,Nama_Item,harga,stok,kategori from TB_PRODUCTS where kategori='" + txtkat.Text + "'";
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

        private void frmstockshirtgirl_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtharga.Text == "" || txtdes.Text == "" || txtkat.Text == "" || txtstok.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdes.Clear();
                txtharga.Clear();
                txtid.Clear();
                return;
            }

            try
            {
                string sql = string.Format("Update TB_PRODUCTS  set Nama_Item ='" + txtdes.Text + "',Harga='" + txtharga.Text + "',stok ='" + txtstok.Text + "' where id='" + lblid.Text + txtid.Text + "' AND kategori='" + txtkat.Text + "'");
                OleDbConnection con = new OleDbConnection(koneksi);
                con.Open();
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Perubahan Data Tersimpan", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds.Clear();
                tampil();
            }
            catch (OleDbException salah)
            {
                MessageBox.Show(salah.ToString());
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Yakin Hapus?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string sql = string.Format("delete * from TB_PRODUCTS  where id='" + lblid.Text + txtid.Text + "' AND kategori='" + txtkat.Text + "'");
                    OleDbConnection con = new OleDbConnection(koneksi);
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    tampil();
                }
            }

            catch (OleDbException salah)
            {
                MessageBox.Show(salah.ToString());
            }
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void btnew_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" || txtharga.Text == "" || txtdes.Text == "" || txtkat.Text == "" || txtstok.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdes.Clear();
                txtharga.Clear();
                txtid.Clear();
            }
            try
            {
                string sql = string.Format("Insert into TB_PRODUCTS (ID,Nama_Item,Harga,stok,kategori) Values('{0}','{1}','{2}','{3}','{4}')", txtid.Text, txtdes.Text, txtharga.Text, txtstok.Text, txtkat.Text);
                OleDbConnection con = new OleDbConnection(koneksi);
                con.Open();
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Tersimpan", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tampil();
            }
            catch (OleDbException salah)
            {
                MessageBox.Show(salah.ToString());
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tampil();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            stok = Convert.ToDouble(txtstok.Text);
            grandstok = stok - 1;
            txtstok.Text = grandstok.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            stok = Convert.ToDouble(txtstok.Text);
            grandstok = stok + 1;
            txtstok.Text = grandstok.ToString();
        }
    }
}
