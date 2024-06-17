namespace Db_Connection
{
    partial class Delete_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Delete_Form));
            button3 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            t_ph = new TextBox();
            t_uname = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.LightSalmon;
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button3.Location = new Point(392, 307);
            button3.Name = "button3";
            button3.Size = new Size(222, 52);
            button3.TabIndex = 24;
            button3.Text = "Back Home";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.LightSalmon;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(392, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSalmon;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(144, 307);
            button1.Name = "button1";
            button1.Size = new Size(148, 52);
            button1.TabIndex = 22;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // t_ph
            // 
            t_ph.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            t_ph.Location = new Point(144, 166);
            t_ph.MaxLength = 11;
            t_ph.Name = "t_ph";
            t_ph.PlaceholderText = "Phone Number";
            t_ph.Size = new Size(207, 38);
            t_ph.TabIndex = 21;
            t_ph.TextAlign = HorizontalAlignment.Center;
            t_ph.TextChanged += t_ph_TextChanged;
            // 
            // t_uname
            // 
            t_uname.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            t_uname.Location = new Point(144, 80);
            t_uname.Name = "t_uname";
            t_uname.PlaceholderText = "UserName";
            t_uname.Size = new Size(207, 38);
            t_uname.TabIndex = 20;
            t_uname.TextAlign = HorizontalAlignment.Center;
            // 
            // Delete_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(t_ph);
            Controls.Add(t_uname);
            Name = "Delete_Form";
            Text = "Delete_Form";
            Load += Delete_Form_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private PictureBox pictureBox1;
        private Button button1;
        private TextBox t_ph;
        private TextBox t_uname;
    }
}