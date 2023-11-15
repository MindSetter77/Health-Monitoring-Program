namespace WinFormsApp1
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            choosePanel = new Panel();
            pictureBox2 = new PictureBox();
            loginPanel = new Panel();
            backButton = new Button();
            pictureBox3 = new PictureBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button4 = new Button();
            registerPanel = new Panel();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            button3 = new Button();
            pictureBox4 = new PictureBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button5 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            choosePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            registerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(973, 596);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(64, 212);
            button1.Name = "button1";
            button1.Size = new Size(233, 50);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.DeepSkyBlue;
            button2.Location = new Point(64, 305);
            button2.Name = "button2";
            button2.Size = new Size(233, 50);
            button2.TabIndex = 1;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // choosePanel
            // 
            choosePanel.BackColor = Color.White;
            choosePanel.Controls.Add(pictureBox2);
            choosePanel.Controls.Add(button2);
            choosePanel.Controls.Add(button1);
            choosePanel.Location = new Point(23, 80);
            choosePanel.Name = "choosePanel";
            choosePanel.Size = new Size(355, 431);
            choosePanel.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(106, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(151, 151);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.White;
            loginPanel.Controls.Add(backButton);
            loginPanel.Controls.Add(pictureBox3);
            loginPanel.Controls.Add(textBox2);
            loginPanel.Controls.Add(textBox1);
            loginPanel.Controls.Add(button4);
            loginPanel.Location = new Point(306, 74);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(355, 431);
            loginPanel.TabIndex = 3;
            // 
            // backButton
            // 
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.ForeColor = Color.DeepSkyBlue;
            backButton.Location = new Point(139, 383);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 23);
            backButton.TabIndex = 3;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.logo_small;
            pictureBox3.Location = new Point(126, 26);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 100);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(62, 239);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(233, 35);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(61, 157);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Login";
            textBox1.Size = new Size(233, 38);
            textBox1.TabIndex = 1;
            // 
            // button4
            // 
            button4.BackColor = Color.DeepSkyBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(61, 307);
            button4.Name = "button4";
            button4.Size = new Size(233, 50);
            button4.TabIndex = 0;
            button4.Text = "Login";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // registerPanel
            // 
            registerPanel.BackColor = Color.White;
            registerPanel.Controls.Add(textBox6);
            registerPanel.Controls.Add(textBox5);
            registerPanel.Controls.Add(button3);
            registerPanel.Controls.Add(pictureBox4);
            registerPanel.Controls.Add(textBox3);
            registerPanel.Controls.Add(textBox4);
            registerPanel.Controls.Add(button5);
            registerPanel.Location = new Point(515, 71);
            registerPanel.Name = "registerPanel";
            registerPanel.Size = new Size(355, 431);
            registerPanel.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(61, 177);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Email";
            textBox6.Size = new Size(233, 35);
            textBox6.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(61, 285);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Repeat Password";
            textBox5.Size = new Size(233, 35);
            textBox5.TabIndex = 4;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.DeepSkyBlue;
            button3.Location = new Point(139, 402);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.logo_small;
            pictureBox4.Location = new Point(124, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 100);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(61, 231);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Password";
            textBox3.Size = new Size(233, 35);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(61, 120);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Login";
            textBox4.Size = new Size(233, 38);
            textBox4.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.DeepSkyBlue;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(61, 339);
            button5.Name = "button5";
            button5.Size = new Size(233, 50);
            button5.TabIndex = 0;
            button5.Text = "Register";
            button5.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 592);
            Controls.Add(choosePanel);
            Controls.Add(registerPanel);
            Controls.Add(loginPanel);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            choosePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            registerPanel.ResumeLayout(false);
            registerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Panel choosePanel;
        private PictureBox pictureBox2;
        private Panel loginPanel;
        private Button button4;
        private PictureBox pictureBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button backButton;
        private Panel registerPanel;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button button3;
        private PictureBox pictureBox4;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button5;
    }
}