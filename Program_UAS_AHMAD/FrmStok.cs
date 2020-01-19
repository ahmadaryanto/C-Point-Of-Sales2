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
    public partial class FrmStok : Form
    {
        public FrmStok()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmtrousergirl menu = new Frmtrousergirl();
            this.Hide();
            menu.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FmMenuUtama menu = new FmMenuUtama();
            this.Hide();
            menu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmstockshirtboy shirtboy = new frmstockshirtboy();
            this.Hide();
            shirtboy.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmstockshirtgirl shirtgil = new frmstockshirtgirl();
            this.Hide();
            shirtgil.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmtrouserboy trouserboy = new frmtrouserboy();
            this.Hide();
            trouserboy.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
