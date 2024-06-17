using Db_Connection.Data;
using System;

namespace Db_Connection
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBcontext db = new DBcontext();
            if (db.Database.EnsureCreated())
            {
                MessageBox.Show("Connection Done");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sign_Up s = new Sign_Up();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBcontext db = new DBcontext();
            string un = un_tx.Text, pass = pass_tx.Text;
            if (!string.IsNullOrWhiteSpace(un) && !string.IsNullOrWhiteSpace(pass))
            {
                var cust = db.Customers.Where(a => a.UserName == un && a.Password == pass).FirstOrDefault();
                //›Ï Õ«·… «‰Â ·ﬁÌÂ
                if (cust != null)
                {
                    MessageBox.Show("Welcome, "+cust.UserName);
                    Items_Form menu = new Items_Form();
                    menu.Show();
                    this.Hide();
                    
                }
                //›Ï Õ«·… „·ﬁ«ÂÊ‘
                else
                {
                    MessageBox.Show("Not Found");
                }
            }
            //›Ï Õ«·… ”«» Õ«Ã… ›«÷Ì… «Ê «·« ‰Ì‰ ›«÷ÌÌ‰
            else
            {
                MessageBox.Show("Please, Enter both of UserName & Password");
            }
        }
    }
}
