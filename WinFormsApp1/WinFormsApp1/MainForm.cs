using System;
using System.Windows.Forms;

namespace MouseFormsApp
{
    public class MainForm : Form
    {
        public MainForm()
        {
            this.Text = "Выбор формы";
            this.Size = new System.Drawing.Size(300, 200);

            Button btnA = new Button { Text = "Form A", Location = new System.Drawing.Point(50, 30), Width = 180 };
            Button btnB = new Button { Text = "Form B", Location = new System.Drawing.Point(50, 70), Width = 180 };
            Button btnC = new Button { Text = "Form C", Location = new System.Drawing.Point(50, 110), Width = 180 };

            btnA.Click += (s, e) => { new FormA().Show(); };
            btnB.Click += (s, e) => { new FormB().Show(); };
            btnC.Click += (s, e) => { new FormC().Show(); };

            this.Controls.Add(btnA);
            this.Controls.Add(btnB);
            this.Controls.Add(btnC);
        }
    }
}