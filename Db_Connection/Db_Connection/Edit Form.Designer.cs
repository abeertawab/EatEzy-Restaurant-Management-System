namespace Db_Connection
{
    partial class Edit_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Form));
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            t_em = new TextBox();
            t_ph = new TextBox();
            t_add = new TextBox();
            t_pass = new TextBox();
            t_uname = new TextBox();
            t_gender = new ComboBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(401, 191);
            button2.Name = "button2";
            button2.Size = new Size(131, 43);
            button2.TabIndex = 18;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 224, 192);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(373, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSalmon;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(97, 345);
            button1.Name = "button1";
            button1.Size = new Size(148, 52);
            button1.TabIndex = 16;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // t_em
            // 
            t_em.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            t_em.Location = new Point(97, 226);
            t_em.Name = "t_em";
            t_em.PlaceholderText = "E-mail";
            t_em.Size = new Size(207, 38);
            t_em.TabIndex = 15;
            t_em.TextAlign = HorizontalAlignment.Center;
            // 
            // t_ph
            // 
            t_ph.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            t_ph.Location = new Point(97, 181);
            t_ph.MaxLength = 11;
            t_ph.Name = "t_ph";
            t_ph.PlaceholderText = "Phone Number";
            t_ph.Size = new Size(207, 38);
            t_ph.TabIndex = 14;
            t_ph.TextAlign = HorizontalAlignment.Center;
            // 
            // t_add
            // 
            t_add.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            t_add.Location = new Point(97, 133);
            t_add.Name = "t_add";
            t_add.PlaceholderText = "Address";
            t_add.Size = new Size(207, 38);
            t_add.TabIndex = 13;
            t_add.TextAlign = HorizontalAlignment.Center;
            // 
            // t_pass
            // 
            t_pass.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            t_pass.Location = new Point(97, 89);
            t_pass.MaxLength = 8;
            t_pass.Name = "t_pass";
            t_pass.PasswordChar = '*';
            t_pass.PlaceholderText = "Password";
            t_pass.Size = new Size(207, 38);
            t_pass.TabIndex = 12;
            t_pass.TextAlign = HorizontalAlignment.Center;
            // 
            // t_uname
            // 
            t_uname.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            t_uname.Location = new Point(97, 39);
            t_uname.Name = "t_uname";
            t_uname.PlaceholderText = "UserName";
            t_uname.Size = new Size(207, 38);
            t_uname.TabIndex = 11;
            t_uname.TextAlign = HorizontalAlignment.Center;
            t_uname.TextChanged += t_uname_TextChanged;
            // 
            // t_gender
            // 
            t_gender.DropDownStyle = ComboBoxStyle.DropDownList;
            t_gender.FormattingEnabled = true;
            t_gender.Items.AddRange(new object[] { "Male", "Female" });
            t_gender.Location = new Point(97, 287);
            t_gender.Name = "t_gender";
            t_gender.Size = new Size(207, 28);
            t_gender.TabIndex = 10;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSalmon;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(268, 345);
            button3.Name = "button3";
            button3.Size = new Size(201, 52);
            button3.TabIndex = 19;
            button3.Text = "Back Home";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Edit_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(t_em);
            Controls.Add(t_ph);
            Controls.Add(t_add);
            Controls.Add(t_pass);
            Controls.Add(t_uname);
            Controls.Add(t_gender);
            Name = "Edit_Form";
            Text = "Edit_Form";
            Load += Edit_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox t_em;
        private TextBox t_ph;
        private TextBox t_add;
        private TextBox t_pass;
        private TextBox t_uname;
        private ComboBox t_gender;
        private Button button3;
    }
}