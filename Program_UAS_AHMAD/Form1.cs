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
    public partial class Form1 : Form
    {
        string koneksi = "Provider = Microsoft.jet.oledb.4.0;Data source=" + Application.StartupPath + "/Gucci_Gang.mdb";
        OleDbConnection Con;
        OleDbCommand Cmd;
        OleDbDataReader Dr;

        public Form1()
        {
            InitializeComponent();
        }


        private void BTlogin_Click(object sender, EventArgs e)
        {
            string User = txtname.Text;
            string Pass = txtpassword.Text;
            Con = new OleDbConnection(koneksi);
            Cmd = new OleDbCommand();
            Con.Open();
            Cmd.Connection = Con;
            Cmd.CommandText = "SELECT * From TB_USER Where Username='" + txtname.Text + "'And Password='" + txtpassword.Text + "'";
            Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                FmMenuUtama F1 = new FmMenuUtama();
                F1.LabelText = this.txtname.Text;
                F1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username Or Password Is Incorrect!");
            }
            Con.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FmMenuUtama menu = new FmMenuUtama();
            this.Hide();
            menu.Show();
        }
    }
}
