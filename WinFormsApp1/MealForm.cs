using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class MealForm : Form
    {
        private Dictionary<string, double> mealOptions = new Dictionary<string, double>
        {
            { "Kurczak", 165 }, // Przykładowe kalorie na 100g dla kurczaka
            { "Ryż", 130 },     // Przykładowe kalorie na 100g dla ryżu
            { "Sałatka", 50 }   // Przykładowe kalorie na 100g dla sałatki
        };

        public MealForm()
        {
            InitializeComponent(); // Inicjalizacja komponentów formularza

            foreach (var meal in mealOptions.Keys)
            {
                comboBox1.Items.Add(meal);
            }
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(141, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 28);
            label1.TabIndex = 1;
            label1.Text = "Dodaj posiłek";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(132, 86);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 156);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(132, 224);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(151, 27);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(163, 280);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 88);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 6;
            label2.Text = "Jedzenie:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 159);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 7;
            label3.Text = "Waga:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 227);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 8;
            label4.Text = "Kalorie:";
            label4.Click += label4_Click;
            // 
            // MealForm
            // 
            ClientSize = new Size(433, 339);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Name = "MealForm";
            Load += MealForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void MealForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Pobierz wybrany produkt z ComboBox
            string selectedMeal = comboBox1.SelectedItem.ToString();

            // Wyświetl przewidywane kalorie na 100g dla wybranego produktu
            double predictedCalories = mealOptions[selectedMeal];
            textBox2.Text = $"{predictedCalories}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Sprawdź, czy wartość w textBox1 jest poprawną liczbą
            double weight;
            if (!double.TryParse(textBox1.Text, out weight))
            {
                textBox2.Text = ""; // Wyczyść textBox2, jeśli wpisana wartość nie jest poprawną liczbą
                return;
            }

            // Pobierz wybrany produkt z ComboBox
            string selectedMeal = comboBox1.SelectedItem.ToString();

            // Oblicz kalorie dla wpisanej wagi produktu
            double predictedCalories = mealOptions[selectedMeal] * (weight / 100.0);

            // Wyświetl przewidywane kalorie dla wpisanej wagi produktu w TextBox2
            textBox2.Text = predictedCalories.ToString("F2");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pobierz wpisaną wagę produktu z TextBox
            double weight;
            if (!double.TryParse(textBox1.Text, out weight))
            {
                MessageBox.Show("Podaj poprawną wagę produktu.");
                return;
            }

            // Pobierz wybrany produkt z ComboBox
            string selectedMeal = comboBox1.SelectedItem.ToString();

            // Oblicz kalorie dla wpisanej wagi produktu
            double predictedCalories = mealOptions[selectedMeal] * (weight / 100.0);

            // Wyświetl przewidywane kalorie dla wpisanej wagi produktu w TextBox
            textBox2.Text = predictedCalories.ToString("F2");

            // Zapisz dane do bazy danych MySQL
            string mysqlCon = "server=127.0.0.1; user=root; database=hrdb; password=";
            MySqlConnection sqlconn = new MySqlConnection(mysqlCon);
            sqlconn.Open();


            string sql = "INSERT INTO meal (meal, weight, calories) VALUES (@meal, @weight, @calories)";
            MySqlCommand cmd = new MySqlCommand(sql, sqlconn);
            cmd.Parameters.AddWithValue("@meal", selectedMeal);
            cmd.Parameters.AddWithValue("@weight", weight);
            cmd.Parameters.AddWithValue("@calories", predictedCalories);

            cmd.ExecuteNonQuery();

            sqlconn.Close();
        }

        private Label label1;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}