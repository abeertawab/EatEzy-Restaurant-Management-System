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
    public partial class Edit_Form : Form
    {
        string selectedimgpath = "";
        private Customer customer;
        DBcontext db = new DBcontext();
        public Edit_Form(Customer customer)
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

        private void Edit_Form_Load(object sender, EventArgs e)
        {
            t_uname.Text = this.customer.UserName;
            t_em.Text = this.customer.Email;
            t_gender.SelectedIndex = (int)this.customer.Gender;
            t_pass.Text = this.customer.Password;
            t_ph.Text = this.customer.Phone_Number;
            t_add.Text = this.customer.Address;
            pictureBox1.ImageLocation = this.customer.image;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = dialog.FileName;
                //مسار الصورة اللى اختارناها
                selectedimgpath = dialog.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.customer.Email = t_em.Text;
            this.customer.Gender = (_Gender)t_gender.SelectedIndex;
            this.customer.Password = t_pass.Text;
            this.customer.UserName = t_uname.Text;
            this.customer.Address = t_add.Text;
            this.customer.Phone_Number = t_ph.Text;
            this.customer.image = pictureBox1.ImageLocation;

            string un = t_uname.Text, pass = t_pass.Text, em = t_em.Text,
                Add = t_add.Text, Ph_Num = t_ph.Text, im = pictureBox1.ImageLocation;
            //_Gender gender = (_Gender)comboBox1.SelectedIndex;
            string emailParts = t_em.Text;
            int f2 = 0, f3 = 0;
            if ((t_ph.Text).Length != 11 && !(t_ph.Text).All(char.IsDigit))
            {
                MessageBox.Show("Phone number not valid");
                f3 = 1;


            }
            else if (f3 == 0)
            {

                f2 = 1;
            }
            int flag = 0, f = 0;
            if (emailParts.Contains("@") && emailParts.Contains(".com"))
            {
                flag = 1;
            }
            else if (flag == 0)
            {
                MessageBox.Show("Email is not valid");
                f = 1;
            }

            if (!string.IsNullOrWhiteSpace(un) && !string.IsNullOrWhiteSpace(pass)
               && !string.IsNullOrWhiteSpace(em) && !string.IsNullOrWhiteSpace(Add)
               && !string.IsNullOrWhiteSpace(Ph_Num) && !string.IsNullOrWhiteSpace(im)
               && (t_ph.Text).Length == 11 && flag == 1 && f2 == 1)

            {

                db.Customers.Update(this.customer);
                db.SaveChanges();
                if (!string.IsNullOrEmpty(selectedimgpath))
                {
                    string dest_path = Environment.CurrentDirectory + "\\images" + this.customer.CustomerId + "_jpg";
                    File.Copy(selectedimgpath, dest_path);
                    this.customer.image = dest_path;
                    db.SaveChanges();
                }
                 MessageBox.Show("Updated");
                Menu dd = new Menu();
                dd.ShowDialog();
            }
            else if (f == 0 && f3 == 0)
            {
                MessageBox.Show("You must fill all cells");
            }


            //db.Customers.Update(this.customer);
            //db.SaveChanges();
            //if (!string.IsNullOrEmpty(selectedimgpath))
            //{
            //    string dest_path = Environment.CurrentDirectory + "\\images" + this.customer.CustomerId + "_jpg";
            //    File.Copy(selectedimgpath, dest_path);
            //    this.customer.image = dest_path;
            //    db.SaveChanges();
            //}
            //MessageBox.Show("Updated");
            //Menu dd = new Menu();
            //dd.ShowDialog();


        }

        private void t_uname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
