using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int saniye = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye <= 5)
            {
                progressBar1.Value += 20;
            }
            if (saniye == 6)
            {
                Form2 Form2 = new Form2();
                Form2.Show();
                this.Hide();
            }
        }

       
    }
}
