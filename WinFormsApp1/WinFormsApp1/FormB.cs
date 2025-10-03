using System;
using System.Windows.Forms;

namespace MouseFormsApp
{
    public class FormB : Form
    {
        private TextBox textBox;

        public FormB()
        {
            this.Text = "Form B - Проверка при закрытии";
            this.Size = new System.Drawing.Size(400, 200);

            textBox = new TextBox { Location = new System.Drawing.Point(50, 50), Width = 200 };
            this.Controls.Add(textBox);

            this.FormClosing += FormB_FormClosing;
        }

        private void FormB_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show("Поле пустое! Заполните его перед закрытием.");
                e.Cancel = true;
            }
        }
    }
}