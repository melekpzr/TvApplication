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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void tRTHDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://trt1.web.tv/");
        }

        private void aTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.atv.com.tr/webtv/canli-yayin");
          //  webBrowser1.Navigate("http://www.ecanlitvizle.com/atv-izle/");
        }

        private void tRTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //  webBrowser1.Navigate("<iframe width="640" height="360" frameborder="0" src="http://web.tv/embed/live/3460" allowfullscreen="allowfullscreen"></iframe>");
        }

        private void sHOWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("https://www.youtube.com/v/5wtt8ah4xyo");
        }

        private void sTARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("");
        }

        private void kANALDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("https://www.kanald.com.tr/embed/542410a361361f36f4c3fcf1");
        }

        private void dİZİMAGEGİTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("");
            Form5 Form5 = new Form5();
            Form5.Show();
            this.Hide();
        }

        private void dİZİPUBAGİTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("");
            Form6 Form6 = new Form6();
            Form6.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            webBrowser1.Visible = true;
        }

        private void fOXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.Navigate("http://www.fox.com.tr/canli-yayin");
            
        }

        private void tV2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
