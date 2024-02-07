namespace gym_management_system
{
    partial class view_Point
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(view_Point));
            button1 = new Button();
            dataGridView1 = new DataGridView();
            search1 = new TextBox();
            textBox8 = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            label8 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.DimGray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.DimGray;
            button1.FlatAppearance.MouseOverBackColor = Color.DimGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(661, 12);
            button1.Name = "button1";
            button1.Size = new Size(64, 62);
            button1.TabIndex = 116;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ControlLight;
            dataGridView1.Location = new Point(12, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(651, 287);
            dataGridView1.TabIndex = 115;
            // 
            // search1
            // 
            search1.Location = new Point(295, 101);
            search1.Name = "search1";
            search1.Size = new Size(145, 23);
            search1.TabIndex = 114;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.DarkGray;
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBox8.ForeColor = Color.Black;
            textBox8.Location = new Point(12, 115);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 26);
            textBox8.TabIndex = 113;
            textBox8.Text = "Power Fitnees";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGray;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Zoom;
            panel3.ForeColor = SystemColors.Desktop;
            panel3.Location = new Point(12, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(100, 104);
            panel3.TabIndex = 112;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(470, 86);
            label2.Name = "label2";
            label2.Size = new Size(10, 15);
            label2.TabIndex = 110;
            label2.Text = " ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(221, 104);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 111;
            label8.Text = " ID Number";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 255, 128);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(486, 95);
            button2.Name = "button2";
            button2.Size = new Size(108, 31);
            button2.TabIndex = 109;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // view_Point
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(726, 450);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(search1);
            Controls.Add(textBox8);
            Controls.Add(panel3);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "view_Point";
            Text = "view_Point";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private TextBox search1;
        private TextBox textBox8;
        private Panel panel3;
        private Label label2;
        private Label label8;
        private Button button2;
    }
}