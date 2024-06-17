namespace Db_Connection.Data
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            custToolStripMenuItem = new ToolStripMenuItem();
            showAllCustomersToolStripMenuItem = new ToolStripMenuItem();
            addNEWCustomerToolStripMenuItem = new ToolStripMenuItem();
            showAllCustomersWithAllOrdersToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, custToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(864, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(128, 26);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // custToolStripMenuItem
            // 
            custToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showAllCustomersToolStripMenuItem, addNEWCustomerToolStripMenuItem, showAllCustomersWithAllOrdersToolStripMenuItem });
            custToolStripMenuItem.Name = "custToolStripMenuItem";
            custToolStripMenuItem.Size = new Size(92, 24);
            custToolStripMenuItem.Text = "Customers";
            // 
            // showAllCustomersToolStripMenuItem
            // 
            showAllCustomersToolStripMenuItem.Name = "showAllCustomersToolStripMenuItem";
            showAllCustomersToolStripMenuItem.Size = new Size(325, 26);
            showAllCustomersToolStripMenuItem.Text = "Show All Customers";
            showAllCustomersToolStripMenuItem.Click += showAllCustomersToolStripMenuItem_Click;
            // 
            // addNEWCustomerToolStripMenuItem
            // 
            addNEWCustomerToolStripMenuItem.Name = "addNEWCustomerToolStripMenuItem";
            addNEWCustomerToolStripMenuItem.Size = new Size(325, 26);
            addNEWCustomerToolStripMenuItem.Text = "Add NEW Customer";
            addNEWCustomerToolStripMenuItem.Click += addNEWCustomerToolStripMenuItem_Click;
            // 
            // showAllCustomersWithAllOrdersToolStripMenuItem
            // 
            showAllCustomersWithAllOrdersToolStripMenuItem.Name = "showAllCustomersWithAllOrdersToolStripMenuItem";
            showAllCustomersWithAllOrdersToolStripMenuItem.Size = new Size(325, 26);
            showAllCustomersWithAllOrdersToolStripMenuItem.Text = "Show All Customers with All Orders";
            showAllCustomersWithAllOrdersToolStripMenuItem.Click += showAllCustomersWithAllOrdersToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(0, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 440);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.LightBlue;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(858, 437);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(864, 513);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem custToolStripMenuItem;
        private ToolStripMenuItem showAllCustomersToolStripMenuItem;
        private ToolStripMenuItem addNEWCustomerToolStripMenuItem;
        private Panel panel1;
        private DataGridView dataGridView1;
        private ToolStripMenuItem showAllCustomersWithAllOrdersToolStripMenuItem;
    }
}