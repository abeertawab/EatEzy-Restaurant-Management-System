namespace Db_Connection.Data
{
    partial class Show_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Form));
            button3 = new Button();
            pictureBox1 = new PictureBox();
            t_em = new TextBox();
            t_ph = new TextBox();
            t_add = new TextBox();
            t_pass = new TextBox();
            t_uname = new TextBox();
            t_gender = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.LightSalmon;
            button3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(592, 354);
            button3.Name = "button3";
            button3.Size = new Size(158, 52);
            button3.TabIndex = 28;
            button3.Text = "Back Home";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 224, 192);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(406, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // t_em
            // 
            t_em.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            t_em.Location = new Point(130, 190);
            t_em.Name = "t_em";
            t_em.PlaceholderText = "E-mail";
            t_em.Size = new Size(207, 38);
            t_em.TabIndex = 25;
            t_em.TextAlign = HorizontalAlignment.Center;
            // 
            // t_ph
            // 
            t_ph.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            t_ph.Location = new Point(130, 145);
            t_ph.MaxLength = 11;
            t_ph.Name = "t_ph";
            t_ph.PlaceholderText = "Phone Number";
            t_ph.Size = new Size(207, 38);
            t_ph.TabIndex = 24;
            t_ph.TextAlign = HorizontalAlignment.Center;
            // 
            // t_add
            // 
            t_add.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            t_add.Location = new Point(130, 97);
            t_add.Name = "t_add";
            t_add.PlaceholderText = "Address";
            t_add.Size = new Size(207, 38);
            t_add.TabIndex = 23;
            t_add.TextAlign = HorizontalAlignment.Center;
            // 
            // t_pass
            // 
            t_pass.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            t_pass.Location = new Point(130, 53);
            t_pass.MaxLength = 8;
            t_pass.Name = "t_pass";
            t_pass.PasswordChar = '*';
            t_pass.PlaceholderText = "Password";
            t_pass.Size = new Size(207, 38);
            t_pass.TabIndex = 22;
            t_pass.TextAlign = HorizontalAlignment.Center;
            // 
            // t_uname
            // 
            t_uname.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            t_uname.Location = new Point(130, 3);
            t_uname.Name = "t_uname";
            t_uname.PlaceholderText = "UserName";
            t_uname.Size = new Size(207, 38);
            t_uname.TabIndex = 21;
            t_uname.TextAlign = HorizontalAlignment.Center;
            // 
            // t_gender
            // 
            t_gender.DropDownStyle = ComboBoxStyle.DropDownList;
            t_gender.FormattingEnabled = true;
            t_gender.Items.AddRange(new object[] { "Male", "Female" });
            t_gender.Location = new Point(130, 251);
            t_gender.Name = "t_gender";
            t_gender.Size = new Size(207, 28);
            t_gender.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 285);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(446, 262);
            dataGridView1.TabIndex = 29;
            // 
            // Show_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(965, 550);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(t_em);
            Controls.Add(t_ph);
            Controls.Add(t_add);
            Controls.Add(t_pass);
            Controls.Add(t_uname);
            Controls.Add(t_gender);
            Name = "Show_Form";
            Text = "Show_Form";
            Load += Show_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private PictureBox pictureBox1;
        private TextBox t_em;
        private TextBox t_ph;
        private TextBox t_add;
        private TextBox t_pass;
        private TextBox t_uname;
        private ComboBox t_gender;
        private DataGridView dataGridView1;
    }
}