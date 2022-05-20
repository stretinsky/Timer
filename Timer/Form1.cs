using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            TimeSpan time;
            if (!TimeSpan.TryParse(maskedTextBox1.Text, out time))
            {
                MessageBox.Show("Некорректные данные");
                return;
            }

            TimerForm timerForm = new TimerForm(time);
            this.Hide();
            if (timerForm.ShowDialog().Equals(DialogResult.OK))
            {
                this.Show();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = "00:00:00";
        }
    }
}
