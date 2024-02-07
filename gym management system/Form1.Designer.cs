namespace gym_management_system
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label13 = new Label();
            label12 = new Label();
            label10 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            button4 = new Button();
            textBox1 = new TextBox();
            search = new Button();
            SuspendLayout();
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.DarkGray;
            label13.Cursor = Cursors.Hand;
            label13.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(12, 203);
            label13.Name = "label13";
            label13.Size = new Size(125, 26);
            label13.TabIndex = 1;
            label13.Text = "Equipment";
            label13.TextAlign = ContentAlignment.TopCenter;
            label13.Click += label13_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.DarkGray;
            label12.Cursor = Cursors.Hand;
            label12.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(12, 238);
            label12.Name = "label12";
            label12.Size = new Size(81, 26);
            label12.TabIndex = 1;
            label12.Text = "Billing";
            label12.TextAlign = ContentAlignment.TopCenter;
            label12.Click += label12_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkGray;
            label10.Cursor = Cursors.Hand;
            label10.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(12, 166);
            label10.Name = "label10";
            label10.Size = new Size(151, 26);
            label10.TabIndex = 1;
            label10.Text = "Memberships";
            label10.TextAlign = ContentAlignment.TopCenter;
            label10.Click += label10_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGray;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 273);
            label1.Name = "label1";
            label1.Size = new Size(97, 26);
            label1.TabIndex = 1;
            label1.Text = "Coching";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.ForeColor = SystemColors.Desktop;
            panel3.Location = new Point(12, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(100, 104);
            panel3.TabIndex = 3;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(12, 442);
            button4.Name = "button4";
            button4.Size = new Size(62, 45);
            button4.TabIndex = 4;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkGray;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(12, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 26);
            textBox1.TabIndex = 5;
            textBox1.Text = "Power Fitnees";
            // 
            // search
            // 
            search.BackColor = Color.Transparent;
            search.BackgroundImage = (Image)resources.GetObject("search.BackgroundImage");
            search.BackgroundImageLayout = ImageLayout.Stretch;
            search.Cursor = Cursors.Hand;
            search.ForeColor = Color.Transparent;
            search.Location = new Point(826, 9);
            search.Name = "search";
            search.Size = new Size(48, 35);
            search.TabIndex = 6;
            search.UseVisualStyleBackColor = false;
            search.Click += search_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(886, 499);
            Controls.Add(search);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(panel3);
            Controls.Add(label10);
            Controls.Add(label1);
            Controls.Add(label12);
            Controls.Add(label13);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.DarkSalmon;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "form";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label12;
        private Label label10;
        private Label label13;
        private Label label1;
        private Panel panel3;
        private Button button4;
        private TextBox textBox1;
        private Button search;
    }
}