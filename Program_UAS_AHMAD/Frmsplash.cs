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

    public partial class Frmsplash : Form
    {
       
        int a;
        int redcolor,greencolor,bluecolor;

        public Frmsplash()
        {
            InitializeComponent();
        }
        

        private void Timer3_Tick(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(redcolor,greencolor,bluecolor);

            if (redcolor == 255)
            {
                redcolor = 0;
            }
            else if (greencolor == 255)
            {
                greencolor = 0;
            }
            else if (bluecolor == 255)
            {
                bluecolor = 0;
            }
            
            else
            {
                bluecolor = bluecolor + 1;
            }
           

        }

        private void Frmsplash_Load(object sender, EventArgs e)
        {
            redcolor = 106; greencolor = 0; bluecolor = 255;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            Label2.Text = "Program is Starting...";
            a = a + 1;
             if( a > 4)
            {
                Form1 login = new Form1();
                login.Show();
                this.Hide();
                Timer2.Enabled = false;
            }
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Label2.Text = "Program is Configuring...";
            Timer1.Enabled = false;
            Timer2.Enabled = true;
        }
    }
}
