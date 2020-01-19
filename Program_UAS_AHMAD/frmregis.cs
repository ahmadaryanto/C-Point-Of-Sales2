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
    public partial class frmregis : Form
    {
        string koneksi = "Provider = Microsoft.jet.oledb.4.0;Data source=" + Application.StartupPath + "/Gucci_Gang.mdb";
        DataSet ds = new DataSet();
        OleDbCommand cmd = new OleDbCommand();

        public frmregis()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
          
            if (txtuser.Text == "" || txtpass.Text == "" || cmbtipe.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Clear();
                txtuser.Clear();
                cmbtipe.Text = "";
                return;
            }


            try
            {
                String sql = String.Format("Insert Into [TB_USER] Values ('{0}','{1}','{2}')", txtuser.Text, txtpass.Text,cmbtipe.Text);
                OleDbConnection con = new OleDbConnection(koneksi);
                con.Open();
                cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Tersimpan", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (OleDbException salah)
            {
                MessageBox.Show(salah.ToString());
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == "" || txtuser.Text == "" || cmbtipe.Text == "" )
            {
                MessageBox.Show("Data tidak boleh kosong", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpass.Clear();
                txtuser.Clear();
                cmbtipe.Text = "";
                return;
            }

            try
            {
                String sql = String.Format("Update [TB_User]  set [Password] ='" + txtpass.Text + "',[Tipe]='" + cmbtipe.Text + "'where [username]='" + txtuser.Text + "'");
                OleDbConnection con = new OleDbConnection(koneksi);
                con.Open();
                OleDbCommand cmd = new OleDbCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Perubahan Data Tersimpan", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ds.Clear();
                txtuser.Clear();
                txtpass.Clear();
            }
            catch (OleDbException salah)
            {
                MessageBox.Show(salah.ToString());

            }
        }
    }
}
