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
    public partial class Bresenham : Form
    {
        public Bresenham()
        {
            InitializeComponent();
        }


        private void drawLine(object sender, EventArgs e)
        {
            int x0 = convertToInt(x0Txt);
            int y0 = convertToInt(y0Txt);
            int xEnd = convertToInt(xEndTxt);
            int yEnd = convertToInt(yEndTxt);

            Axis.DrawAxes(bresenahmPanel);
            Point p0 = new Point(x0, y0);
            Point p1 = new Point(xEnd, yEnd);
            //p0 = Axis.PreparePoint(p0, bresenahmPanel);
            //p1 = Axis.PreparePoint(p1, bresenahmPanel);
            DrawLineUsingBresenham(p0.X, p0.Y, p1.X, p1.Y);
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

        private void DrawLineUsingBresenham(int x0, int y0, int xEnd, int yEnd)
        {
            int dx = Math.Abs(xEnd - x0), dy = Math.Abs(yEnd - y0);
            int x, y, p = 2 * dy - dx;
            int twoDy = 2 * dy, twoDyMinusDx = 2 * (dy - dx);

            /* Determine which endpoint to use as start position.  */
            if (x0 > xEnd)
            {
                x = xEnd; y = yEnd; xEnd = x0;
            }
            else
            {
                x = x0; y = y0;
            }

            var aBrush = Brushes.Black;
            
            var g = bresenahmPanel.CreateGraphics();
            
            //g.FillRectangle(aBrush, x, y, 4, 4);
            Point point;

            while (x < xEnd)
            {
                x++;
                if (p < 0)
                    p += twoDy;
                else
                {
                    y++;
                    p += twoDyMinusDx;
                }
                //xPlotted = Axis.Centralize_X_Axis(x, bresenahmPanel);
                //yPlotted = Axis.Centralize_Y_Axis(y, bresenahmPanel);
                point = new Point(x, y);
                point = Axis.PreparePoint(point, bresenahmPanel);
                g.FillRectangle(aBrush, point.X, point.Y, 4, 4);
                //g.FillRectangle(aBrush, xPlotted, yPlotted, 4, 4);
                //g.FillRectangle(aBrush, x, y, 4, 4);

            }

        }

        

        private void clearButton_Click(object sender, EventArgs e)
        {
            bresenahmPanel.Controls.Clear();
            x0Txt.Clear();
            y0Txt.Clear();
            xEndTxt.Clear();
            yEndTxt.Clear();
            this.Refresh();
        }
    }
}
