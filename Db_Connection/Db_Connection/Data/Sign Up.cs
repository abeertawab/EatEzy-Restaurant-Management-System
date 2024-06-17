using DBconnection.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Db_Connection.Data
{
    public partial class Sign_Up : Form
    {
        string selectedimgpath = "";
        string projimgpath = Environment.CurrentDirectory + "\\images";
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBcontext db = new DBcontext();

            Customer a1 = new Customer()
            {
                UserName = un_tx.Text,
                Email = em_tx.Text,
                Password = pass_tx.Text,
                Gender = (_Gender)comboBox1.SelectedIndex, //Casting
                Address = add_tx.Text,
                Phone_Number = ph_tx.Text,
                image = "Noimage"
            };
            string un = un_tx.Text, pass = pass_tx.Text, em = em_tx.Text,
                Add = add_tx.Text, Ph_Num = ph_tx.Text,im= pictureBox1.ImageLocation;
            //_Gender gender = (_Gender)comboBox1.SelectedIndex;
            string emailParts = em_tx.Text;
            int f2 = 0,f3=0;
            if ((ph_tx.Text).Length != 11 && !(ph_tx.Text).All(char.IsDigit))
            {
                MessageBox.Show("Phone number not valid");
                f3 = 1;


            }
            else if(f3==0)
            {
                
                f2 = 1;
            }
            int flag = 0,f=0;
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
                && (ph_tx.Text).Length == 11 &&flag==1&&f2==1)
            
            {

                db.Customers.Add(a1);
                db.SaveChanges();
                if (!string.IsNullOrWhiteSpace(selectedimgpath))
                {
                    string newimgpath = projimgpath + "\\" + a1.CustomerId + "_.jpg";
                    File.Copy(selectedimgpath, newimgpath);
                    a1.image = newimgpath;
                    db.SaveChanges();
                }
                MessageBox.Show("Added Successfully");
                LogIn l = new LogIn();
                l.Show();
                this.Hide();
            }
            else if(f==0&&f3==0)
            {
                MessageBox.Show("You must fill all cells");
            }


        }

        private void em_tx_TextChanged(object sender, EventArgs e)
        {

        }

        private void ph_tx_TextChanged(object sender, EventArgs e)
        {

        }

        private void im_tx_TextChanged(object sender, EventArgs e)
        {

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
