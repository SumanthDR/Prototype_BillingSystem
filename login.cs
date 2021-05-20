using System;
using System.Windows.Forms;

namespace project.cs
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String j = "admin", k = "admin";
            home hs = new home();
            if ((txtboxuser.Text == j) && (txtboxpswd.Text == k))
                hs.Show();
            else
                MessageBox.Show("Invalid Input");
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are You Sure Do You Want To Exit The Program?","Click OK To Quit",MessageBoxButtons.YesNo);
            if(confirm.Equals(DialogResult.Yes))
            {
                this.Close();
            }

        }

        private void txtboxuser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
