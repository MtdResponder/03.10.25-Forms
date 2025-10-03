using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MouseFormsApp
{
    public class FormC : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;

        public FormC()
        {
            this.Text = "Form C - Треугольная форма";
            this.Size = new Size(400, 400);
            this.FormBorderStyle = FormBorderStyle.None;

            GraphicsPath path = new GraphicsPath();
            Point[] points = {
                new Point(this.Width / 2, 0),
                new Point(0, this.Height),
                new Point(this.Width, this.Height)
            };
            path.AddPolygon(points);
            this.Region = new Region(path);

            this.MouseDown += FormC_MouseDown;
            this.MouseMove += FormC_MouseMove;
            this.MouseUp += FormC_MouseUp;
        }

        private void FormC_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = true;
                mouseOffset = new Point(-e.X, -e.Y);
            }
        }

        private void FormC_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                this.Location = mousePos;
            }
        }

        private void FormC_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
    }
}