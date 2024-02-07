namespace gym_management_system
{
    partial class loging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loging));
            login = new Button();
            button2 = new Button();
            textBoxuser = new TextBox();
            textBoxpasw = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // login
            // 
            login.BackColor = Color.DarkGray;
            login.Cursor = Cursors.Hand;
            login.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            login.Location = new Point(105, 272);
            login.Name = "login";
            login.Size = new Size(89, 53);
            login.TabIndex = 0;
            login.Text = "log in ";
            login.UseVisualStyleBackColor = false;
            login.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(200, 272);
            button2.Name = "button2";
            button2.Size = new Size(86, 53);
            button2.TabIndex = 0;
            button2.Text = "Clean";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBoxuser
            // 
            textBoxuser.BackColor = Color.WhiteSmoke;
            textBoxuser.Location = new Point(187, 142);
            textBoxuser.Name = "textBoxuser";
            textBoxuser.Size = new Size(168, 23);
            textBoxuser.TabIndex = 1;
            // 
            // textBoxpasw
            // 
            textBoxpasw.BackColor = Color.WhiteSmoke;
            textBoxpasw.Location = new Point(187, 192);
            textBoxpasw.Name = "textBoxpasw";
            textBoxpasw.Size = new Size(168, 23);
            textBoxpasw.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.DarkGray;
            textBox3.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.InactiveCaptionText;
            textBox3.Location = new Point(64, 142);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(86, 24);
            textBox3.TabIndex = 1;
            textBox3.Text = "User name";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.DarkGray;
            textBox4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox4.Location = new Point(64, 192);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(86, 24);
            textBox4.TabIndex = 1;
            textBox4.Text = "Password";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Silver;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Times New Roman", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            textBox5.ForeColor = Color.Black;
            textBox5.Location = new Point(105, 62);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(196, 37);
            textBox5.TabIndex = 7;
            textBox5.Text = "Power Fitnees";
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Location = new Point(348, 0);
            button3.Name = "button3";
            button3.Size = new Size(48, 41);
            button3.TabIndex = 8;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // loging
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(399, 380);
            Controls.Add(button3);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBoxpasw);
            Controls.Add(textBox3);
            Controls.Add(textBoxuser);
            Controls.Add(button2);
            Controls.Add(login);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "loging";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "loging";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login;
        private Button button2;
        private TextBox textBoxuser;
        private TextBox textBoxpasw;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button3;
    }
}