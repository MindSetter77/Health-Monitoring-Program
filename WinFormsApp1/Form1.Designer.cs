﻿namespace WinFormsApp1
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
            mainPanel = new Panel();
            panel1 = new Panel();
            bmiBtn = new Button();
            foodBtn = new Button();
            mainBtn = new Button();
            label1 = new Label();
            foodPanel = new Panel();
            button7 = new Button();
            button6 = new Button();
            dataGridView1 = new DataGridView();
            addDayBtn = new Button();
            minusDayBtn = new Button();
            dateLabel = new Label();
            caloryLabel = new Label();
            bmiPanel = new Panel();
            label3 = new Label();
            SGpanel = new Panel();
            saveChangesBtn = new Button();
            ageTB = new TextBox();
            sexTB = new TextBox();
            heightTB = new TextBox();
            weightTB = new TextBox();
            nameTB = new TextBox();
            ageLabel = new Label();
            sexLabel = new Label();
            wzrostLabel = new Label();
            wagaLabel = new Label();
            nameLabel = new Label();
            infonewLabel = new Label();
            bmiOpinion = new Label();
            bmiInput = new Label();
            label2 = new Label();
            bmiMainLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            choosePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            registerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            mainPanel.SuspendLayout();
            panel1.SuspendLayout();
            foodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            bmiPanel.SuspendLayout();
            SGpanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -4);
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
            choosePanel.Location = new Point(306, 74);
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
            registerPanel.Location = new Point(306, 74);
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
            // mainPanel
            // 
            mainPanel.BackgroundImage = (Image)resources.GetObject("mainPanel.BackgroundImage");
            mainPanel.Controls.Add(panel1);
            mainPanel.Controls.Add(foodPanel);
            mainPanel.Controls.Add(SGpanel);
            mainPanel.Controls.Add(bmiPanel);
            mainPanel.Location = new Point(0, -1);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(973, 596);
            mainPanel.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(bmiBtn);
            panel1.Controls.Add(foodBtn);
            panel1.Controls.Add(mainBtn);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(219, 596);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // bmiBtn
            // 
            bmiBtn.Location = new Point(12, 204);
            bmiBtn.Name = "bmiBtn";
            bmiBtn.Size = new Size(189, 37);
            bmiBtn.TabIndex = 5;
            bmiBtn.Text = "BMI";
            bmiBtn.UseVisualStyleBackColor = true;
            bmiBtn.Click += bmiBtn_Click;
            // 
            // foodBtn
            // 
            foodBtn.Location = new Point(12, 139);
            foodBtn.Name = "foodBtn";
            foodBtn.Size = new Size(189, 37);
            foodBtn.TabIndex = 4;
            foodBtn.Text = "Jedzenie";
            foodBtn.UseVisualStyleBackColor = true;
            foodBtn.Click += foodBtn_Click;
            // 
            // mainBtn
            // 
            mainBtn.BackColor = Color.Transparent;
            mainBtn.Location = new Point(15, 75);
            mainBtn.Name = "mainBtn";
            mainBtn.Size = new Size(189, 38);
            mainBtn.TabIndex = 3;
            mainBtn.Text = "Strona główna";
            mainBtn.UseVisualStyleBackColor = false;
            mainBtn.Click += mainBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 22);
            label1.Name = "label1";
            label1.Size = new Size(89, 24);
            label1.TabIndex = 2;
            label1.Text = "Zdrowie";
            label1.Click += label1_Click;
            // 
            // foodPanel
            // 
            foodPanel.BackColor = SystemColors.Control;
            foodPanel.Controls.Add(button7);
            foodPanel.Controls.Add(button6);
            foodPanel.Controls.Add(dataGridView1);
            foodPanel.Controls.Add(addDayBtn);
            foodPanel.Controls.Add(minusDayBtn);
            foodPanel.Controls.Add(dateLabel);
            foodPanel.Controls.Add(caloryLabel);
            foodPanel.Location = new Point(226, 10);
            foodPanel.Name = "foodPanel";
            foodPanel.Size = new Size(732, 569);
            foodPanel.TabIndex = 4;
            foodPanel.Paint += foodPanel_Paint;
            // 
            // button7
            // 
            button7.Location = new Point(449, 112);
            button7.Name = "button7";
            button7.Size = new Size(46, 44);
            button7.TabIndex = 10;
            button7.Text = "-";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(625, 112);
            button6.Name = "button6";
            button6.Size = new Size(46, 44);
            button6.TabIndex = 9;
            button6.Text = "+";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(19, 112);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(327, 411);
            dataGridView1.TabIndex = 8;
            // 
            // addDayBtn
            // 
            addDayBtn.Location = new Point(521, 58);
            addDayBtn.Name = "addDayBtn";
            addDayBtn.Size = new Size(75, 35);
            addDayBtn.TabIndex = 7;
            addDayBtn.Text = "🢂";
            addDayBtn.UseVisualStyleBackColor = true;
            addDayBtn.Click += addDayBtn_Click;
            // 
            // minusDayBtn
            // 
            minusDayBtn.Location = new Point(157, 58);
            minusDayBtn.Name = "minusDayBtn";
            minusDayBtn.Size = new Size(72, 36);
            minusDayBtn.TabIndex = 6;
            minusDayBtn.Text = "🢀";
            minusDayBtn.UseVisualStyleBackColor = true;
            minusDayBtn.Click += minusDayBtn_Click;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(318, 66);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(56, 22);
            dateLabel.TabIndex = 5;
            dateLabel.Text = "data";
            dateLabel.Click += dateLabel_Click;
            // 
            // caloryLabel
            // 
            caloryLabel.AutoSize = true;
            caloryLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            caloryLabel.Location = new Point(228, 19);
            caloryLabel.Name = "caloryLabel";
            caloryLabel.Size = new Size(280, 22);
            caloryLabel.TabIndex = 0;
            caloryLabel.Text = "Zapotrzebowanie kaloryczne:";
            // 
            // bmiPanel
            // 
            bmiPanel.Controls.Add(label3);
            bmiPanel.Controls.Add(infonewLabel);
            bmiPanel.Controls.Add(bmiOpinion);
            bmiPanel.Controls.Add(bmiInput);
            bmiPanel.Controls.Add(label2);
            bmiPanel.Controls.Add(bmiMainLabel);
            bmiPanel.Location = new Point(225, 9);
            bmiPanel.Name = "bmiPanel";
            bmiPanel.Size = new Size(736, 572);
            bmiPanel.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(58, 385);
            label3.Name = "label3";
            label3.Size = new Size(94, 23);
            label3.TabIndex = 9;
            label3.Text = "Wartości:";
            label3.Click += label3_Click;
            // 
            // SGpanel
            // 
            SGpanel.Controls.Add(saveChangesBtn);
            SGpanel.Controls.Add(ageTB);
            SGpanel.Controls.Add(sexTB);
            SGpanel.Controls.Add(heightTB);
            SGpanel.Controls.Add(weightTB);
            SGpanel.Controls.Add(nameTB);
            SGpanel.Controls.Add(ageLabel);
            SGpanel.Controls.Add(sexLabel);
            SGpanel.Controls.Add(wzrostLabel);
            SGpanel.Controls.Add(wagaLabel);
            SGpanel.Controls.Add(nameLabel);
            SGpanel.Location = new Point(226, 10);
            SGpanel.Name = "SGpanel";
            SGpanel.Size = new Size(736, 572);
            SGpanel.TabIndex = 1;
            // 
            // saveChangesBtn
            // 
            saveChangesBtn.Location = new Point(308, 523);
            saveChangesBtn.Name = "saveChangesBtn";
            saveChangesBtn.Size = new Size(121, 31);
            saveChangesBtn.TabIndex = 11;
            saveChangesBtn.Text = "Zapisz zmiany";
            saveChangesBtn.UseVisualStyleBackColor = true;
            saveChangesBtn.Click += saveChangesBtn_Click;
            // 
            // ageTB
            // 
            ageTB.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ageTB.Location = new Point(84, 158);
            ageTB.Name = "ageTB";
            ageTB.Size = new Size(141, 31);
            ageTB.TabIndex = 10;
            // 
            // sexTB
            // 
            sexTB.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sexTB.Location = new Point(84, 124);
            sexTB.Name = "sexTB";
            sexTB.Size = new Size(141, 31);
            sexTB.TabIndex = 9;
            // 
            // heightTB
            // 
            heightTB.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            heightTB.Location = new Point(84, 89);
            heightTB.Name = "heightTB";
            heightTB.Size = new Size(141, 31);
            heightTB.TabIndex = 8;
            // 
            // weightTB
            // 
            weightTB.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            weightTB.Location = new Point(84, 53);
            weightTB.Name = "weightTB";
            weightTB.Size = new Size(141, 31);
            weightTB.TabIndex = 7;
            // 
            // nameTB
            // 
            nameTB.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nameTB.Location = new Point(84, 16);
            nameTB.Name = "nameTB";
            nameTB.Size = new Size(141, 31);
            nameTB.TabIndex = 6;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ageLabel.Location = new Point(31, 161);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(62, 22);
            ageLabel.TabIndex = 5;
            ageLabel.Text = "Wiek: ";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sexLabel.Location = new Point(33, 127);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new Size(61, 22);
            sexLabel.TabIndex = 3;
            sexLabel.Text = "Płeć: ";
            // 
            // wzrostLabel
            // 
            wzrostLabel.AutoSize = true;
            wzrostLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            wzrostLabel.Location = new Point(18, 92);
            wzrostLabel.Name = "wzrostLabel";
            wzrostLabel.Size = new Size(77, 22);
            wzrostLabel.TabIndex = 2;
            wzrostLabel.Text = "Wzrost: ";
            wzrostLabel.Click += label2_Click_2;
            // 
            // wagaLabel
            // 
            wagaLabel.AutoSize = true;
            wagaLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            wagaLabel.Location = new Point(18, 53);
            wagaLabel.Name = "wagaLabel";
            wagaLabel.Size = new Size(76, 22);
            wagaLabel.TabIndex = 1;
            wagaLabel.Text = "Waga: ";
            wagaLabel.Click += label2_Click_1;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            nameLabel.Location = new Point(34, 20);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(57, 22);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Imie: ";
            nameLabel.Click += label2_Click;
            // 
            // infonewLabel
            // 
            infonewLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            infonewLabel.Location = new Point(158, 386);
            infonewLabel.Name = "infonewLabel";
            infonewLabel.Size = new Size(331, 96);
            infonewLabel.TabIndex = 8;
            infonewLabel.Text = "asd";
            // 
            // bmiOpinion
            // 
            bmiOpinion.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bmiOpinion.Location = new Point(286, 198);
            bmiOpinion.Name = "bmiOpinion";
            bmiOpinion.Size = new Size(171, 44);
            bmiOpinion.TabIndex = 7;
            bmiOpinion.Text = "label3";
            bmiOpinion.TextAlign = ContentAlignment.TopCenter;
            // 
            // bmiInput
            // 
            bmiInput.Font = new Font("Century Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point);
            bmiInput.Location = new Point(235, 69);
            bmiInput.Name = "bmiInput";
            bmiInput.Size = new Size(323, 110);
            bmiInput.TabIndex = 6;
            bmiInput.Text = "0.0";
            // 
            // label2
            // 
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 277);
            label2.Name = "label2";
            label2.Size = new Size(694, 97);
            label2.TabIndex = 5;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Click += label2_Click_5;
            // 
            // bmiMainLabel
            // 
            bmiMainLabel.AutoSize = true;
            bmiMainLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bmiMainLabel.Location = new Point(275, 41);
            bmiMainLabel.Name = "bmiMainLabel";
            bmiMainLabel.Size = new Size(193, 25);
            bmiMainLabel.TabIndex = 3;
            bmiMainLabel.Text = "Twoje BMI wynosi:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 592);
            Controls.Add(mainPanel);
            Controls.Add(registerPanel);
            Controls.Add(choosePanel);
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
            mainPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            foodPanel.ResumeLayout(false);
            foodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            bmiPanel.ResumeLayout(false);
            bmiPanel.PerformLayout();
            SGpanel.ResumeLayout(false);
            SGpanel.PerformLayout();
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
        private Panel mainPanel;
        private Panel panel1;
        private Label label1;
        private Button mainBtn;
        private Button foodBtn;
        private Panel SGpanel;
        private Label nameLabel;
        private Label wagaLabel;
        private Label wzrostLabel;
        private Label sexLabel;
        private Button bmiBtn;
        private Panel bmiPanel;
        private Label bmiMainLabel;
        private Panel foodPanel;
        private Label caloryLabel;
        private TextBox nameTB;
        private Label ageLabel;
        private TextBox ageTB;
        private TextBox sexTB;
        private TextBox heightTB;
        private TextBox weightTB;
        private Button saveChangesBtn;
        private Label label2;
        private Label bmiInput;
        private Label bmiOpinion;
        private Label infonewLabel;
        private Label label3;
        private Label dateLabel;
        private Button addDayBtn;
        private Button minusDayBtn;
        private DataGridView dataGridView1;
        private Button button7;
        private Button button6;
    }
}