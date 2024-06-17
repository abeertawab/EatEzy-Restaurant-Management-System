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

namespace Db_Connection.Data
{
    public partial class Show_Form : Form
    {
        string selectedimgpath = "";
        private Customer customer;
        DBcontext db = new DBcontext();
        public Show_Form(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu d = new Menu();
            this.Hide();
            d.ShowDialog();
        }

        private void Show_Form_Load(object sender, EventArgs e)
        {
            t_uname.Text = this.customer.UserName;
            t_em.Text = this.customer.Email;
            t_gender.SelectedIndex = (int)this.customer.Gender;
            t_pass.Text = this.customer.Password;
            t_ph.Text = this.customer.Phone_Number;
            t_add.Text = this.customer.Address;
            pictureBox1.ImageLocation = this.customer.image;

            var query = from cust in db.Customers
                        join ord in db.Orders on cust.CustomerId equals ord.CustomerId
                        where this.customer.UserName == cust.UserName
                        select new { ord.items,ord.TotalPrice,ord.OrderDate };

            dataGridView1.DataSource = query.ToList();

        }

    }
}
