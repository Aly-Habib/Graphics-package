using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Draw_line
{
    class Axis
    {
        private static void Draw_Y_Axis(Panel panel)
        {
            var aBrush = Brushes.Black;
            var g = panel.CreateGraphics();
            int panelWidth = panel.Width;
            int middle = panelWidth / 2;
            int panelHeight = panel.Height;
            for (int i = 0; i < panelHeight; i++)
            {
                g.FillRectangle(aBrush, middle, i, 4, 4);
            }
        }
        private static void Draw_X_Axis(Panel panel)
        {
            var aBrush = Brushes.Black;
            var g = panel.CreateGraphics();
            int panelWidth = panel.Width;
            int middle = panelWidth / 2;
            int panelHeight = panel.Height;
            for (int i = 0; i < panelWidth; i++)
            {
                g.FillRectangle(aBrush, i, middle, 4, 4);
            }
        }
        public static void DrawAxes(Panel panel)
        {
            Draw_X_Axis(panel);
            Draw_Y_Axis(panel);
        }
        public static int Centralize_X_Axis(int x, Panel panel)
        {
            int newX = 0;
            if(x > 0)
            {
                newX = (panel.Width / 2) + x;
            }
            else if( x < 0)
            {
                newX = (panel.Width / 2) + x;
            }
            else if(x==0)
            {
                newX = panel.Width / 2;
            }
            return newX;
        }
        public static int Centralize_Y_Axis(int y, Panel panel)
        {
            int newY = 0;
            if (y < 0)
            {
                newY = (panel.Height / 2) + Math.Abs(y);
            }
            else if (y > 0)
            {
                newY = (panel.Height / 2) - y;
            }
            else
            {
                newY = panel.Height / 2;
            }
            return newY;
        }
        public static Point PreparePoint(Point point, Panel panel)
        {
            Point newpoint = new Point(point.X, point.Y);
            if(point.X > 0)
            {
                if(point.Y > 0)
                {
                    newpoint.X = panel.Width / 2 + point.X;
                    newpoint.Y = panel.Height / 2 - point.Y;
                }
                else 
                {
                    newpoint.X = panel.Width / 2 + point.X;
                    newpoint.Y = panel.Height / 2 - point.Y;
                }
            }
            else if(point.X < 0)
            {
                if(point.Y > 0)
                {
                    newpoint.X = panel.Width / 2 + point.X;
                    newpoint.Y = panel.Height / 2 - point.Y;
                }
                else
                {
                    newpoint.X = panel.Width / 2 + point.X;
                    newpoint.Y = panel.Height / 2 - point.Y;
                }
            }
            else
            {
                newpoint.Y = panel.Height / 2;
                newpoint.X = panel.Width / 2;
            }


            return newpoint;
        }
        
    }
}

