using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_UAS_AHMAD
{
    public partial class frmbayar : Form
    {
        public frmbayar(string sTEXT)
        {
            InitializeComponent();
            txtpembelian.Text = sTEXT;
        }

        public frmbayar()
        {
            InitializeComponent();
        }

        private void frmbayar_Load(object sender, EventArgs e)
        {
            int value1 = Convert.ToInt32(this.txtpembelian.Text);
            double value2 = 0.10;
            double value3 = (value1) * (value2);
            txttax.Text = value3.ToString();
        }

        private void txtbayar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int value1 = Convert.ToInt32(this.txtpembelian.Text);
                double value2 = 0.10;
                double value3 = (value1) * (value2);
                double jlhbeli = (value1) + (value3);
                double value4 = Convert.ToInt32(this.txtbayar.Text);
                double jlhbayar = (value4) - (jlhbeli);
                txtkembali.Text = jlhbayar.ToString();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FmMenuUtama menu = new FmMenuUtama();
            this.Hide();
            menu.Show();
        }
    }
}
