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
    public partial class frmstockshirtgirl : Form
    {
        string koneksi = "Provider = Microsoft.jet.oledb.4.0;Data source=" + Application.StartupPath + "/Gucci_Gang.mdb";
        DataSet ds = new DataSet();
        OleDbCommand cmd = new OleDbCommand();


        double grandstok, stok;
        string filename1, filename2;

        public frmstockshirtgirl()
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
            string sql = "select ID,Nama_Item,harga,stok,kategori,gambar from TB_PRODUCTS where id='" + lblid.Text + txtid.Text + "' AND kategori='" + txtkat.Text + "'";
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
            if (txtid.Text == "" || txtharga.Text == "" || txtdes.Text == "" || txtkat.Text == "" || txtstok.Text == "" || lblfilename.Text == "" || lblfilename.Text == "-")
            {
                MessageBox.Show("Data tidak boleh kosong", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdes.Clear();
                txtharga.Clear();
                txtstok.Clear();
                txtid.Clear();
                lblfilename.Text = "-";
                lblfilename2.Text = "-";
                return;
            }

            try
            {
                string sql = string.Format("Update TB_PRODUCTS  set Nama_Item ='" + txtdes.Text + "',Harga='" + txtharga.Text + "',stok ='" + txtstok.Text + "',gambar ='" + Path.Combine(new string[] { Application.StartupPath, lblfilename.Text }) + "'where id='" + lblid.Text + txtid.Text + "' AND kategori='" + txtkat.Text + "'");
                OleDbConnection con = new OleDbConnection(koneksi);
                con.Open();
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Perubahan Data Tersimpan", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds.Clear();
                tampil();
                txtdes.Clear();
                txtharga.Clear();
                txtstok.Clear();
                txtid.Clear();
                lblfilename.Text = "-";
                lblfilename2.Text = "-";
                pictureBox1.Image = null;
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

                    txtstok.Clear();
                    lblfilename.Text = "-";
                    lblfilename2.Text = "-";
                    txtdes.Clear();
                    txtharga.Clear();
                    txtid.Clear();
                    pictureBox1.Image = null;

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
            if (txtid.Text == "" || txtharga.Text == "" || txtdes.Text == "" || txtkat.Text == "" || txtstok.Text == "" || lblfilename.Text == "" || lblfilename.Text == "-")
            {
                MessageBox.Show("Data tidak boleh kosong", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdes.Clear();
                txtharga.Clear();
                txtstok.Clear();
                txtid.Clear();
                lblfilename.Text = "-";
                lblfilename2.Text = "-";
                return;
            }
            try
            {

                string sql = string.Format("Insert into TB_PRODUCTS (ID,Nama_Item,Harga,stok,kategori,gambar) Values('{0}','{1}','{2}','{3}','{4}','{5}')", lblid.Text + txtid.Text, txtdes.Text, txtharga.Text, txtstok.Text, txtkat.Text, Path.Combine(new string[] { Application.StartupPath, lblfilename.Text }));
                OleDbConnection con = new OleDbConnection(koneksi);
                con.Open();

                cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Tersimpan", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tampil();
                txtdes.Clear();
                txtharga.Clear();
                txtstok.Clear();
                txtid.Clear();
                lblfilename.Text = "-";
                lblfilename2.Text = "-";
                pictureBox1.Image = null;
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

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            lblfilename.Text = "-";
            lblfilename2.Text = "-";

        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.JPG", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {

                    filename1 = ofd.FileName;
                    filename2 = ofd.FileName;

                    filename1 = Path.GetFileName(filename1);


                    lblfilename2.Text = filename1;
                    lblfilename.Text = filename2;
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox1.Image = Image.FromFile(filename2);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtharga_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtharga.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtharga.Text = txtharga.Text.Remove(txtharga.Text.Length - 1);
            }
        }

        private void txtstok_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtharga.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtstok.Text = txtstok.Text.Remove(txtstok.Text.Length - 1);
            }
        }

        private void DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DG.Rows[e.RowIndex];
                string text1 = row.Cells["ID"].Value.ToString();
                string retString;
                retString = text1.Substring(3);
                txtid.Text = retString;

                txtdes.Text = row.Cells["Nama_Item"].Value.ToString();
                txtharga.Text = row.Cells["Harga"].Value.ToString();
                txtstok.Text = row.Cells["stok"].Value.ToString();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Image.FromFile(row.Cells["gambar"].Value.ToString());
                lblfilename.Text = row.Cells["gambar"].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            stok = Convert.ToDouble(txtstok.Text);
            grandstok = stok + 1;
            txtstok.Text = grandstok.ToString();
        }
    }
}
