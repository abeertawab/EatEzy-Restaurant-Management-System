namespace Db_Connection.Data
{
    partial class Sign_Up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_Up));
            comboBox1 = new ComboBox();
            label1 = new Label();
            un_tx = new TextBox();
            pass_tx = new TextBox();
            add_tx = new TextBox();
            ph_tx = new TextBox();
            em_tx = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.DisplayMember = "male";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.ImeMode = ImeMode.NoControl;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(178, 371);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(207, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Tomato;
            label1.Location = new Point(312, 24);
            label1.Name = "label1";
            label1.Size = new Size(120, 46);
            label1.TabIndex = 0;
            label1.Text = "Eat-EZ";
            // 
            // un_tx
            // 
            un_tx.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            un_tx.Location = new Point(178, 123);
            un_tx.Name = "un_tx";
            un_tx.PlaceholderText = "UserName";
            un_tx.Size = new Size(207, 38);
            un_tx.TabIndex = 2;
            un_tx.TextAlign = HorizontalAlignment.Center;
            // 
            // pass_tx
            // 
            pass_tx.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            pass_tx.Location = new Point(178, 173);
            pass_tx.MaxLength = 8;
            pass_tx.Name = "pass_tx";
            pass_tx.PasswordChar = '*';
            pass_tx.PlaceholderText = "Password";
            pass_tx.Size = new Size(207, 38);
            pass_tx.TabIndex = 3;
            pass_tx.TextAlign = HorizontalAlignment.Center;
            // 
            // add_tx
            // 
            add_tx.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            add_tx.Location = new Point(178, 217);
            add_tx.Name = "add_tx";
            add_tx.PlaceholderText = "Address";
            add_tx.Size = new Size(207, 38);
            add_tx.TabIndex = 4;
            add_tx.TextAlign = HorizontalAlignment.Center;
            // 
            // ph_tx
            // 
            ph_tx.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            ph_tx.Location = new Point(178, 265);
            ph_tx.MaxLength = 11;
            ph_tx.Name = "ph_tx";
            ph_tx.PlaceholderText = "Phone Number";
            ph_tx.Size = new Size(207, 38);
            ph_tx.TabIndex = 5;
            ph_tx.TextAlign = HorizontalAlignment.Center;
            ph_tx.TextChanged += ph_tx_TextChanged;
            // 
            // em_tx
            // 
            em_tx.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            em_tx.Location = new Point(178, 310);
            em_tx.Name = "em_tx";
            em_tx.PlaceholderText = "E-mail";
            em_tx.Size = new Size(207, 38);
            em_tx.TabIndex = 6;
            em_tx.TextAlign = HorizontalAlignment.Center;
            em_tx.TextChanged += em_tx_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Salmon;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(423, 371);
            button1.Name = "button1";
            button1.Size = new Size(148, 52);
            button1.TabIndex = 7;
            button1.Text = "Sign Up";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(255, 224, 192);
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(454, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(482, 275);
            button2.Name = "button2";
            button2.Size = new Size(131, 43);
            button2.TabIndex = 9;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Sign_Up
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(em_tx);
            Controls.Add(ph_tx);
            Controls.Add(add_tx);
            Controls.Add(pass_tx);
            Controls.Add(un_tx);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "Sign_Up";
            Text = "Sign_Up";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox un_tx;
        private TextBox pass_tx;
        private TextBox add_tx;
        private TextBox ph_tx;
        private TextBox em_tx;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        internal ComboBox comboBox1;
    }
}