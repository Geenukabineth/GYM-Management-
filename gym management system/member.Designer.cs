namespace gym_management_system
{
    partial class member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(member));
            textBox8 = new TextBox();
            panel3 = new Panel();
            label8 = new Label();
            button4 = new Button();
            button2 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.DarkGray;
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox8.ForeColor = Color.Black;
            textBox8.Location = new Point(10, 112);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 26);
            textBox8.TabIndex = 88;
            textBox8.Text = "Power Fitnees";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.ForeColor = SystemColors.Desktop;
            panel3.Location = new Point(10, 7);
            panel3.Name = "panel3";
            panel3.Size = new Size(100, 104);
            panel3.TabIndex = 87;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(221, 63);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 83;
            label8.Text = " ID Number";
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(700, 7);
            button4.Name = "button4";
            button4.Size = new Size(68, 53);
            button4.TabIndex = 78;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(458, 63);
            button2.Name = "button2";
            button2.Size = new Size(172, 31);
            button2.TabIndex = 76;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 255, 128);
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(295, -25);
            label1.Name = "label1";
            label1.Size = new Size(192, 24);
            label1.TabIndex = 64;
            label1.Text = "Supervising Coaches";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(307, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 23);
            textBox1.TabIndex = 89;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(351, 45);
            label2.Name = "label2";
            label2.Size = new Size(10, 15);
            label2.TabIndex = 83;
            label2.Text = " ";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ControlLight;
            dataGridView1.Location = new Point(22, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(756, 279);
            dataGridView1.TabIndex = 90;
            // 
            // member
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(textBox8);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "member";
            StartPosition = FormStartPosition.CenterParent;
            Text = "member";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox8;
        private Panel panel3;
        private Label label8;
        private Button button4;
        private Button button2;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private DataGridView dataGridView1;
    }
}