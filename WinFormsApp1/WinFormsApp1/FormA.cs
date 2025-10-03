using System;
using System.Windows.Forms;

namespace MouseFormsApp
{
    public class FormA : Form
    {
        public FormA()
        {
            this.Text = "Form A - Координаты мыши";
            this.Size = new System.Drawing.Size(400, 300);

            this.MouseMove += FormA_MouseMove;
        }

        private void FormA_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"X: {e.X}, Y: {e.Y}";
        }
    }
}