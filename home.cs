using System;
using System.Windows.Forms;

namespace project.cs
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FeeStructure fs = new FeeStructure();
            fs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bill bs = new Bill();
            bs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Statistics ss = new Statistics();
            ss.Show();
        }
    }
}
