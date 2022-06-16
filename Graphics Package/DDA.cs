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
    public partial class DDALine : Form
    {
        public DDALine()
        {
            InitializeComponent();
        }

        
        
        private void DrawLineUsingDDA(int x0, int y0, int xEnd, int yEnd)
        {
            int dx = xEnd - x0, dy = yEnd - y0, steps, k;
            double xIncrement, yIncrement, x = x0, y = y0;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xIncrement = (double)dx / (double)steps;
            yIncrement = (double)dy / (double)steps;
            var aBrush = Brushes.Black;
            //SolidBrush aBrush = new SolidBrush(Color.Black);
            var g = panel2.CreateGraphics();
            

            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;

                int xPlotted = (int)(Math.Round(x));
                int yPlotted = (int)(Math.Round(y));
                g.FillRectangle(aBrush, xPlotted, yPlotted, 4, 4);
                
               
            }
        }
        
        public static int convertToInt(TextBox x)
        {
            try
            {
                return Convert.ToInt32(x.Text);
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        private void drawLine(object sender, EventArgs e)
        {
            Axis.DrawAxes(panel2);

            int x0 = Axis.Centralize_X_Axis(convertToInt(x0Txt), panel2);
            int y0 = Axis.Centralize_Y_Axis(convertToInt(y0Txt), panel2);
            int xEnd = Axis.Centralize_X_Axis(convertToInt(xEndTxt), panel2);
            int yEnd = Axis.Centralize_Y_Axis(convertToInt(yEndTxt), panel2);

            DrawLineUsingDDA(x0, y0, xEnd, yEnd);
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            x0Txt.Clear();
            y0Txt.Clear();
            xEndTxt.Clear();
            yEndTxt.Clear();
            this.Refresh();
        }
    }
}
