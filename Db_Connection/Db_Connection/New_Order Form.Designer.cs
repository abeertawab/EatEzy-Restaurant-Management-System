namespace Db_Connection
{
    partial class New_Order_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Order_Form));
            label1 = new Label();
            un_tex = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            i_tex = new TextBox();
            p_tex = new TextBox();
            Ord_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightGreen;
            label1.Font = new Font("Segoe UI Black", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(255, 67);
            label1.Name = "label1";
            label1.Size = new Size(345, 50);
            label1.TabIndex = 0;
            label1.Text = "Your Eat-EZ Order";
            label1.Click += label1_Click;
            // 
            // un_tex
            // 
            un_tex.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            un_tex.Location = new Point(141, 163);
            un_tex.Name = "un_tex";
            un_tex.PlaceholderText = "UserName";
            un_tex.Size = new Size(292, 44);
            un_tex.TabIndex = 1;
            un_tex.TextAlign = HorizontalAlignment.Center;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(141, 385);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(292, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // i_tex
            // 
            i_tex.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            i_tex.Location = new Point(141, 232);
            i_tex.Name = "i_tex";
            i_tex.PlaceholderText = "Item";
            i_tex.Size = new Size(292, 44);
            i_tex.TabIndex = 5;
            i_tex.TextAlign = HorizontalAlignment.Center;
            // 
            // p_tex
            // 
            p_tex.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            p_tex.Location = new Point(141, 302);
            p_tex.Name = "p_tex";
            p_tex.PlaceholderText = "Price";
            p_tex.Size = new Size(292, 44);
            p_tex.TabIndex = 6;
            p_tex.TextAlign = HorizontalAlignment.Center;
            // 
            // Ord_btn
            // 
            Ord_btn.BackColor = Color.LightGreen;
            Ord_btn.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Ord_btn.Location = new Point(594, 426);
            Ord_btn.Name = "Ord_btn";
            Ord_btn.Size = new Size(127, 66);
            Ord_btn.TabIndex = 7;
            Ord_btn.Text = "Order";
            Ord_btn.UseVisualStyleBackColor = false;
            Ord_btn.Click += Ord_btn_Click;
            // 
            // New_Order_Form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(945, 528);
            Controls.Add(Ord_btn);
            Controls.Add(p_tex);
            Controls.Add(i_tex);
            Controls.Add(dateTimePicker1);
            Controls.Add(un_tex);
            Controls.Add(label1);
            Name = "New_Order_Form";
            Text = "New_Order_Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox un_tex;
        private DateTimePicker dateTimePicker1;
        private TextBox i_tex;
        private TextBox p_tex;
        private Button Ord_btn;
    }
}