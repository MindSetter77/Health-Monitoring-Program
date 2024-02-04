namespace WinFormsApp1
{
    partial class Form2
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
            label1 = new Label();
            posilek = new TextBox();
            kalorie = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 37);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Posiłek:";
            label1.Click += label1_Click;
            // 
            // posilek
            // 
            posilek.Location = new Point(80, 34);
            posilek.Name = "posilek";
            posilek.Size = new Size(100, 23);
            posilek.TabIndex = 1;
            // 
            // kalorie
            // 
            kalorie.Location = new Point(80, 92);
            kalorie.Name = "kalorie";
            kalorie.Size = new Size(100, 23);
            kalorie.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 95);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 2;
            label2.Text = "Kalorie:";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(71, 155);
            button1.Name = "button1";
            button1.Size = new Size(75, 44);
            button1.TabIndex = 6;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(217, 241);
            Controls.Add(button1);
            Controls.Add(kalorie);
            Controls.Add(label2);
            Controls.Add(posilek);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox posilek;
        private TextBox kalorie;
        private Label label2;
        private Button button1;
    }
}