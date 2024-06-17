using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Db_Connection
{
    public partial class Items_Form : Form
    {
        public Items_Form()
        {
            InitializeComponent();
        }

        private void OrderNow_Click(object sender, EventArgs e)
        {
            New_Order_Form n = new New_Order_Form();
            n.Show();
            this.Hide();
        }
    }
}
