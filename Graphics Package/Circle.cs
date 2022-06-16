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
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
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
        void DrawCircle(int xCenter, int yCenter, int radius)
        {
            int x = 0;
            int y = radius;
            int p = 1 - radius;
            
            circlePlotPoints(xCenter, yCenter, x, y);

            while(x < y)
            {
                x++;
                if (p < 0)
                    p += 2 * x + 1;
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                circlePlotPoints(xCenter, yCenter, x, y);
            }

        }
        void circlePlotPoints(int xCenter, int yCenter, int x, int y)
        {
            var aBrush = Brushes.Black;
            var g = panel2.CreateGraphics();

            g.FillRectangle(aBrush, xCenter + x, yCenter + y, 4, 4);
            g.FillRectangle(aBrush, xCenter - x, yCenter + y, 4, 4);
            g.FillRectangle(aBrush, xCenter + x, yCenter - y, 4, 4);
            g.FillRectangle(aBrush, xCenter - x, yCenter - y, 4, 4);
            g.FillRectangle(aBrush, xCenter + y, yCenter + x, 4, 4);
            g.FillRectangle(aBrush, xCenter - y, yCenter + x, 4, 4);
            g.FillRectangle(aBrush, xCenter + y, yCenter - x, 4, 4);
            g.FillRectangle(aBrush, xCenter - y, yCenter - x, 4, 4);
        }

        private void draw_Click(object sender, EventArgs e)
        {
            Axis.DrawAxes(panel2);
            int xCenter = convertToInt(xCenterTxt);
            int yCenter = convertToInt(yCenterTxt);
            int radius = convertToInt(radiusTxt);
            int xPlotted = Axis.Centralize_X_Axis(xCenter, panel2);
            int yPlotted= Axis.Centralize_Y_Axis(yCenter, panel2);


            DrawCircle(xPlotted, yPlotted, radius);

        }

        private void clear_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            xCenterTxt.Clear();
            yCenterTxt.Clear();
            radiusTxt.Clear();
            this.Refresh();
        }

        int round(double x)
        {
            return (int)Math.Round(x);
        }

        void ellipseMidpoint(int xCenter, int yCenter, int Rx, int Ry)
        {
            int Rx2 = Rx * Rx; int Ry2 = Ry * Ry;
            int twoRx2 = 2 * Rx2; int twoRy2 = 2 * Ry2;
            int p; int x = 0; int y = Ry; int px = 0;
            int py = twoRx2 * y;
            //void ellipsePlotPoints(int, int, int, int);
            /* Plot the initial point in each quadrant. */
            ellipsePlotPoints(xCenter, yCenter, x, y);
            /* Region 1 */
            p = round(Ry2 - (Rx2 * Ry) + (0.25 * Rx2));
            while (px < py)
            {
                x++;
                px += twoRy2;
                if (p < 0)
                    p += Ry2 + px;
                else
                {
                    y--;
                    py -= twoRx2;
                    p += Ry2 + px - py;
                }
                ellipsePlotPoints(xCenter, yCenter, x, y);
            }

            /* Region 2 */
            p = round(Ry2 * (x + 0.5) * (x + 0.5) + Rx2 * (y - 1) * (y - 1) - Rx2 * Ry2);
            while (y > 0)
            {
                y--; py -= twoRx2;
                if (p > 0)
                    p += Rx2 - py;
                else
                {
                    x++;
                    px += twoRy2;
                    p += Rx2 - py + px;
                }
                ellipsePlotPoints(xCenter, yCenter, x, y);
            }
        }

        void ellipsePlotPoints(int xCenter, int yCenter, int x, int y)
        {
            var aBrush = Brushes.Black;
            var g = panel2.CreateGraphics();

            g.FillRectangle(aBrush, xCenter + x, yCenter + y, 4, 4);
            g.FillRectangle(aBrush, xCenter - x, yCenter + y, 4, 4);
            g.FillRectangle(aBrush, xCenter + x, yCenter - y, 4, 4);
            g.FillRectangle(aBrush, xCenter - x, yCenter - y, 4, 4);
        }

        private void drawEllipse_Click(object sender, EventArgs e)
        {
            Axis.DrawAxes(panel2);
            int xCenter = convertToInt(xCenterTxt);
            int yCenter = convertToInt(yCenterTxt);
            int xRadius = convertToInt(xRadiusTxt);
            int yRadius = convertToInt(yRadiusTxt);
            int xPlotted = Axis.Centralize_X_Axis(xCenter, panel2);
            int yPlotted = Axis.Centralize_Y_Axis(yCenter, panel2);

            ellipseMidpoint(xCenter, yCenter, xRadius, yRadius);
        }
    }
}
