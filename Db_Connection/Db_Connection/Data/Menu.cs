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
    public partial class Menu : Form
    {
        DBcontext db = new DBcontext();
        public Menu()
        {
            InitializeComponent();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNEWCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sign_Up ss = new Sign_Up();
            this.Hide();
            ss.ShowDialog();

        }

        private void showAllCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var all_customers = db.Customers.ToList();
            var Customers = from cust in all_customers select new { cust.CustomerId, cust.Email, cust.UserName };
            dataGridView1.DataSource = Customers.ToList();
            dataGridView1.Columns.Add(new DataGridViewButtonColumn { Text = "Edit", Name = "Edit", UseColumnTextForButtonValue = true });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn { Text = "Show", Name = "Show", UseColumnTextForButtonValue = true });
            dataGridView1.Columns.Add(new DataGridViewButtonColumn { Text = "Delete", Name = "Delete", UseColumnTextForButtonValue = true });
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //الصف اللى بتدوس عليه بيرجعلك
                //ال id بتاعه
                var row = dataGridView1.Rows[e.RowIndex];
                var a_id = Convert.ToInt32(row.Cells["CustomerId"].Value);
                Customer selected = db.Customers.Where(a => a.CustomerId == a_id).FirstOrDefault();
                //انت واقف فى انهى عمود
                if (e.ColumnIndex == dataGridView1.Columns["Edit"].Index)
                {
                    if (selected != null)
                    {
                        MessageBox.Show("Edit, " + selected.UserName);
                        Edit_Form ef = new Edit_Form(selected);
                        this.Hide();
                        ef.ShowDialog();
                    }
                }
                if (e.ColumnIndex == dataGridView1.Columns["Show"].Index)
                {
                    MessageBox.Show("Show, " + selected.UserName);
                    Show_Form sf = new Show_Form(selected);
                    this.Hide();
                    sf.ShowDialog();
                }
                if (e.ColumnIndex == dataGridView1.Columns["Delete"].Index)
                {
                    Delete_Form df = new Delete_Form(selected);
                    this.Hide();
                    df.ShowDialog();
                }
            }
        }

        private void showAllCustomersWithAllOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var query = from cust in db.Customers
                        join ord in db.Orders on cust.CustomerId equals ord.CustomerId
                        select new { cust.UserName, cust.Phone_Number, ord.items, ord.TotalPrice, ord.OrderDate };

            dataGridView1.DataSource = query.ToList();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
