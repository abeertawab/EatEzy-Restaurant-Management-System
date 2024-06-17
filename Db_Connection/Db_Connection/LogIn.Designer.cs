namespace Db_Connection
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            button1 = new Button();
            un_tx = new TextBox();
            pass_tx = new TextBox();
            button2 = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(663, 420);
            button1.Name = "button1";
            button1.Size = new Size(138, 29);
            button1.TabIndex = 0;
            button1.Text = "DB connection";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // un_tx
            // 
            un_tx.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            un_tx.Location = new Point(288, 168);
            un_tx.Name = "un_tx";
            un_tx.PlaceholderText = "UserName";
            un_tx.Size = new Size(227, 43);
            un_tx.TabIndex = 1;
            un_tx.TextAlign = HorizontalAlignment.Center;
            // 
            // pass_tx
            // 
            pass_tx.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            pass_tx.Location = new Point(288, 231);
            pass_tx.MaxLength = 8;
            pass_tx.Name = "pass_tx";
            pass_tx.PasswordChar = '*';
            pass_tx.PlaceholderText = "Password";
            pass_tx.Size = new Size(227, 43);
            pass_tx.TabIndex = 2;
            pass_tx.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("Cambria", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(357, 292);
            button2.Name = "button2";
            button2.Size = new Size(95, 41);
            button2.TabIndex = 3;
            button2.Text = "Log In";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(215, 344);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 4;
            label1.Text = "No Account?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BackColor = Color.Transparent;
            linkLabel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            linkLabel1.Location = new Point(334, 341);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(84, 28);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Sign Up";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(pass_tx);
            Controls.Add(un_tx);
            Controls.Add(button1);
            Name = "LogIn";
            Text = "LogIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox un_tx;
        private TextBox pass_tx;
        private Button button2;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}
