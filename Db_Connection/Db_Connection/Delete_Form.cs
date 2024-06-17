using Db_Connection.Data;
using DBconnection.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Db_Connection
{
    public partial class Delete_Form : Form
    {
        private Customer customer;
        DBcontext db = new DBcontext();
        public Delete_Form(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void t_ph_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.customer.UserName = t_uname.Text;
            this.customer.Phone_Number = t_ph.Text;
            this.customer.image = pictureBox1.ImageLocation;
            db.Customers.Remove(this.customer);
            db.SaveChanges();
            MessageBox.Show("Delete Successfully");
            Menu dd = new Menu();
            this.Hide();
            dd.ShowDialog();
        }

        private void Delete_Form_Load(object sender, EventArgs e)
        {
            t_uname.Text = this.customer.UserName;
            t_ph.Text = this.customer.Phone_Number;
            pictureBox1.ImageLocation = this.customer.image;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu d = new Menu();
            this.Hide();
            d.ShowDialog();
        }
    }
}
