using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneComparisonHome
{
    public partial class frmHome : Form
    {

        public frmHome()
        {
            InitializeComponent();
            pnlPhnComp.Visible = false;
        }

        public static Color SetTransparency(int A, Color color)
        {
            return Color.FromArgb(A, color.R, color.G, color.B);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
        }

        private void btnHome_Click(object sender, EventArgs e)
        {


            pnlPhnComp.Visible = false;
            btnHome.BackColor = Color.FromArgb(91, 155, 213);
            btnPhone.BackColor = Color.FromArgb(224, 224, 224);

        }

        private void btnPhone_Click(object sender, EventArgs e)
        {

            pnlPhnComp.Visible = true;
            btnPhone.BackColor = Color.FromArgb(91, 155, 213);
            btnHome.BackColor = Color.FromArgb(224, 224, 224);

        }
    }
}
