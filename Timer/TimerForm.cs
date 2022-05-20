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
    public partial class TimerForm : Form
    {
        TimeSpan time;
        TimeSpan second = new TimeSpan(0, 0, 1);
        public TimerForm(TimeSpan time)
        {
            InitializeComponent();
            this.time = time;
        }

        private void TimerForm_Load(object sender, EventArgs e)
        {
            timerLabel.Text = time.ToString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time -= second;
            timerLabel.Text = time.ToString(@"hh\:mm\:ss");
            if (time < second)
            {
                timer1.Stop();
                MessageBox.Show("пилип-пилип готово");
                DialogResult = DialogResult.OK;
            }
        }
    }
}
