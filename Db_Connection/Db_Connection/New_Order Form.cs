using Db_Connection.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Db_Connection
{
    public partial class New_Order_Form : Form
    {
        public New_Order_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ord_btn_Click(object sender, EventArgs e)
        {
            
                DBcontext db = new DBcontext();
                string UserName = un_tex.Text;
                if (UserName.ToString() != "")
                {
                    var a = db.Customers.Where(x => x.UserName == UserName).FirstOrDefault();
                    Order o = new Order()

                    {
                        items = i_tex.Text,
                        TotalPrice = p_tex.Text,
                        CustomerId = a.CustomerId,
                        OrderDate = dateTimePicker1.Value
                    };
                    if (string.IsNullOrWhiteSpace(i_tex.Text) || string.IsNullOrWhiteSpace(p_tex.Text))
                    {
                        MessageBox.Show("You MUST fill ALL cells");
                    }
                    else if ((i_tex.Text == "Grilled Chicken Salad" && p_tex.Text == "100") ||
                        (i_tex.Text == "Lentil Soup" && p_tex.Text == "70") ||
                        (i_tex.Text == "Greek Yogurt with Fresh Fruits" && p_tex.Text == "65") ||
                        (i_tex.Text == "Chicken Shawarma Sandwich" && p_tex.Text == "40") ||
                        (i_tex.Text == "Falafel Sandwich" && p_tex.Text == "15") ||
                        (i_tex.Text == "Koshari" && p_tex.Text == "30") ||
                        (i_tex.Text == "Hawawshi" && p_tex.Text == "50") ||
                        (i_tex.Text == "Beef Kebab Plate" && p_tex.Text == "60") ||
                        (i_tex.Text == "Chicken Kofta Sandwich" && p_tex.Text == "55") ||
                        (i_tex.Text == "Alexanderia Kofta Sandwich" && p_tex.Text == "45") ||
                        (i_tex.Text == "Cheeseburger Sandwich" && p_tex.Text == "55") ||
                        (i_tex.Text == "French Fries" && p_tex.Text == "34") ||
                        (i_tex.Text == "White Souce Pasta" && p_tex.Text == "83") ||
                        (i_tex.Text == "Red Souce Pasta" && p_tex.Text == "63") ||
                        (i_tex.Text == "Pizza" && p_tex.Text.ToString() == "110")
                        )
                    {
                        MessageBox.Show("Order Done");
                        db.Orders.Add(o);
                        db.SaveChanges();
                    }
                    else
                    {
                        MessageBox.Show("Item or Price is NOT valid");
                    }

                    Menu l = new Menu();
                    l.Show();
                    this.Hide();
                }
                else
                {
                MessageBox.Show("UserName maybe NULL");
            }
            
            
           
         }   
    }
}
