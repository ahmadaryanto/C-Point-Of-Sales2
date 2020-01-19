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
    public partial class FmMenuUtama : Form
    {
        string koneksi = "Provider = Microsoft.jet.oledb.4.0;Data source=" + Application.StartupPath + "/Gucci_Gang.mdb";
        DataSet ds = new DataSet();
        OleDbCommand cmd = new OleDbCommand();
        DataTable table = new DataTable();
        string waktu = DateTime.Now.ToString("HH:mm:ss");
        private void tampil()
        {
            ds.Clear();
            string sql = "select ID,Nama_Item,harga,stok,kategori,gambar from TB_PRODUCTS";
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
            string sql = "select ID,Nama_Item,harga,stok,kategori,gambar from TB_PRODUCTS where id='" + TXTCARI.Text +  "'";
            OleDbConnection con = new OleDbConnection(koneksi);
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter(sql, con);
            da.Fill(ds, "TB_PRODUCTS");
            con.Close();
            DG.DataSource = ds.Tables["TB_PRODUCTS"].DefaultView;
        }

        public FmMenuUtama()
        {
            InitializeComponent();
        }


     
        private void FmMenuUtama_Load(object sender, EventArgs e)
        {
            tampil();
            this.DG.Columns["gambar"].Visible = false;
            this.DG.Columns["Kategori"].Visible = false;
            table.Columns.Add("id_item", typeof(string));
            table.Columns.Add("nama_item", typeof(string));
            table.Columns.Add("HARGA", typeof(string));
            table.Columns.Add("QTY", typeof(string));
            table.Columns.Add("TOTAL", typeof(string));

          
        }

        private void button15_Click(object sender, EventArgs e)
        {

            int custambah, cust;
           
            cust = Convert.ToInt32(lblnocust.Text);
            custambah = cust + 1;
            lblnocust.Text = custambah.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void DG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.DG.Rows[e.RowIndex];
                txtitem.Text = row.Cells["Nama_Item"].Value.ToString();
                lblharga.Text = row.Cells["harga"].Value.ToString();
                txtid.Text = row.Cells["id"].Value.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttambah_Click(object sender, EventArgs e)
        {
            if (this.txtitem.Text == "" || this.txtjumlah.Text == "" || this.lblharga.Text == "" || this.txtid.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Double value1 = Convert.ToDouble(this.lblharga.Text);
            Double value2 = Convert.ToDouble(this.txtjumlah.Text);
            Double value3 = (value1) * (value2);
       
            table.Rows.Add(txtid.Text, txtitem.Text, txtjumlah.Text, lblharga.Text, value3);
            dataGridView1.DataSource = table;
            txtitem.Clear();
            txtjumlah.Clear();
            
            lblharga.Text = "0";
            double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[3].Value);
            }
            double tax = sum * 0.10;
            lbltax.Text = tax.ToString("#,##0");
            lblgrand.Text = sum.ToString("#,##0");
           
        }

        private void btnew_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.DataSource != null)
            {
                this.dataGridView1.DataSource = null;
                table.Clear();
                lblgrand.Text = "-";
                lbltax.Text = "-";
            }
            else
            {
                this.dataGridView1.Rows.Clear();
            }

        }

        private void txtjumlah_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtjumlah.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtjumlah.Text = txtjumlah.Text.Remove(txtjumlah.Text.Length - 1);
            }
        }

        private void btsave_Click(object sender, EventArgs e)
        {
           
            if (this.dataGridView1.DataSource != null)
            {
                OleDbConnection con = new OleDbConnection(koneksi);
                
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                
                {
                    con.Open();

                    string sql = string.Format("Insert into TB_PEMESANAN (IDPemesanan,ID_Customer,ID_Barang,Nama_Item,harga,QTY,GrandTotal) Values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", "PS " + waktu , "cs" + lblnocust.Text + waktu ,
                       dataGridView1.Rows[i].Cells["id_item"].Value, dataGridView1.Rows[i].Cells["Nama_ITEM"].Value , dataGridView1.Rows[i].Cells["QTY"].Value ,  dataGridView1.Rows[i].Cells["Harga"].Value , dataGridView1.Rows[i].Cells["TOTAL"].Value);

                
                    cmd = new OleDbCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                this.dataGridView1.DataSource = null;

               
            }
            else
            {
                MessageBox.Show("DATA TIDAK BOLEH KOSONG");
                this.dataGridView1.Rows.Clear();
            }
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tampil();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
            lbljam.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
