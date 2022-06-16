using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draw_line
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void dda_Click(object sender, EventArgs e)
        {
            DDALine dda = new DDALine();
            dda.Show();
        }

        private void bresenham_Click(object sender, EventArgs e)
        {
            Bresenham br = new Bresenham();
            br.Show();
        }

        private void circle_Click(object sender, EventArgs e)
        {
            Circle cir = new Circle(); 
            cir.Show();
            Ellipse ellipse = new Ellipse();
            ellipse.Show();
        }

        private void ellipse_Click(object sender, EventArgs e)
        {
            Circle cir = new Circle();
            cir.Show();
            Ellipse ellipse = new Ellipse();
            ellipse.Show();
        }
    }
}
