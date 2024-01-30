using System.Data;
using System.Xml.Serialization;

using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        int id = 0;
        double bmi = 0;

        // Definicja delegata dla metody
        private Action makeSqlDbMealsDelegate;

        String plec = "";
        int wagai = 0;
        int wzrosti = 0;
        public DateTime dzienWyswietlany;

        public DataGridView dgv_instance;

        public Form1()
        {
            InitializeComponent();

            instance = this;

            // Przypisanie metody do delegata
            makeSqlDbMealsDelegate = makeSqlDbMeals;


            mainBtn.FlatStyle = FlatStyle.Flat;
            foodBtn.FlatStyle = FlatStyle.Flat;
            bmiBtn.FlatStyle = FlatStyle.Flat;


            this.Size = new System.Drawing.Size(989, 631);
            loginPanel.Visible = false;
            registerPanel.Visible = false;
            mainPanel.Visible = false;
            bmiPanel.Visible = false;
            foodPanel.Visible = false;
            infonewLabel.Text = "(0 - 18.5) - Niedowaga\r\n(18.5 - 24.9) - Waga prawid³owa\r\n(25 - 29.9) - Nadwaga\r\n(30+) - Oty³oœæ ";
            dzienWyswietlany = DateTime.Today;
        }

        public void RunMakeSqlDbMeals()
        {
            // Wywo³anie metody za pomoc¹ delegata
            makeSqlDbMealsDelegate?.Invoke();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            choosePanel.Visible = false;
            loginPanel.Visible = true;
            textBox1.Text = "Alex";

            textBox2.Text = "123";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            choosePanel.Visible = false;
            registerPanel.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = false;
            choosePanel.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            registerPanel.Visible = false;
            choosePanel.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            String login = textBox1.Text;
            String password = textBox2.Text;

            String name = "";
            Boolean logged = false;


            String mysqlCon = "server=127.0.0.1; user=root; database=hrdb; password=";
            MySqlConnection sqlconn = new MySqlConnection(mysqlCon);
            try
            {
                sqlconn.Open();
                if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Uzupe³nij wszystkie pola");
                }
                else
                {
                    MySqlCommand mySqlCommand = new MySqlCommand("select * from users", sqlconn);
                    MySqlDataReader reader = mySqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        if (login.Equals(reader.GetString("username")) && password.Equals(reader.GetString("password")))
                        {
                            logged = true;
                            id = reader.GetInt32("id");
                            name = reader.GetString("username");
                        }
                    }
                    if (logged == false)
                    {
                        MessageBox.Show("Nie mo¿na zalogowaæ");
                    }
                    else
                    {

                        loginPanel.Visible = false;
                        mainPanel.Visible = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlconn.Close();
            }

            if (logged) { loggedSuccesfully(); }

            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void loggedSuccesfully()
        {
            String mysqlCon = "server=127.0.0.1; user=root; database=hrdb; password=";
            MySqlConnection sqlconn = new MySqlConnection(mysqlCon);
            sqlconn.Open();

            String sql = "SELECT * FROM dane WHERE ID = " + id;
            MySqlCommand mySqlCommand = new MySqlCommand(sql, sqlconn);

            using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
            {
                if (reader.Read()) // Sprawdzamy, czy s¹ dostêpne dane do odczytu
                {
                    string imie = reader["Imie"].ToString();
                    string waga = reader["waga"].ToString();
                    string wzrost = reader["wzrost"].ToString();
                    plec = reader["plec"].ToString();
                    int wiek = int.Parse(reader["wiek"].ToString());

                    //BMI

                    wzrosti = int.Parse(wzrost);
                    wagai = int.Parse(waga);

                    double wzrost100 = double.Parse(wzrost) / 100;

                    bmi = wagai / (wzrost100 * wzrost100);

                    bmiInput.Text = bmi.ToString("F2");
                    if (bmi < 18.5)
                        bmiOpinion.Text = "(Niedowaga)";
                    else if (bmi >= 18.5 && bmi < 24.9)
                        bmiOpinion.Text = "(Waga prawid³owa)";
                    else if (bmi >= 25 && bmi < 29.9)
                        bmiOpinion.Text = "(Nadwaga)";
                    else
                        bmiOpinion.Text = "(Oty³oœæ)";

                    imie = string.IsNullOrEmpty(imie) ? "Uzupe³nij informacjê!" : imie;

                    waga = string.IsNullOrEmpty(waga) ? "Uzupe³nij informacjê!" : waga;
                    wzrost = string.IsNullOrEmpty(wzrost) ? "Uzupe³nij informacjê!" : wzrost;

                    plec = string.IsNullOrEmpty(plec) ? "Uzupe³nij informacjê!" : plec;

                    //Zapotrzebowanie kaloryczne

                    if (plec.Equals("Mê¿czyzna"))
                    {
                        double pal = 1.7;
                        double bmrMezczyzna = (66 + (13.7 * wagai) + (5 * wzrosti) - (6.8 * wiek) * pal);
                        //double bmr = (10 * wagai) + (6.25 * wzrosti) - (5 * wiek) + 5;
                        caloryLabel.Text += " " + bmrMezczyzna.ToString("F0");

                    }
                    else
                    {
                        double bmr = (10 * wagai) + (6.25 * wzrosti) - (5 * wiek) - 161;
                        caloryLabel.Text += bmr;
                    }

                    sqlconn.Close();

                    nameTB.Text = imie;
                    weightTB.Text += waga;
                    heightTB.Text += wzrost;
                    sexTB.Text += plec;
                    ageTB.Text += wiek;
                }
                else
                {
                    MessageBox.Show("Brak danych");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_2(object sender, EventArgs e)
        {

        }

        private void bmiBtn_Click(object sender, EventArgs e)
        {
            bmiPanel.Visible = true;
            SGpanel.Visible = false;
            foodPanel.Visible = false;
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            SGpanel.Visible = true;
            bmiPanel.Visible = false;
            foodPanel.Visible = false;
        }

        private void label2_Click_3(object sender, EventArgs e)
        {

        }

        private string makeSql_for_meal(DateTime time)
        {
            int[] desiredPositions = { 0, 1, 3, 4, 6, 7, 8, 9 };
            string result = "";

            string originalString = time.ToString();

            foreach (var position in desiredPositions)
            {
                if (position < originalString.Length) // SprawdŸ, czy pozycja nie wykracza poza d³ugoœæ stringa
                {
                    result += originalString[position]; // Dodaj znak z danej pozycji do wyniku
                }
            }

            string sql = "select meal_in_day_number, meal, calories from meal where date_id = " + result + " AND user_id = " + id;
            return sql;


        }

        public void makeSqlDbMeals()
        {
            String mysqlCon = "server=127.0.0.1; user=root; database=hrdb; password=";
            MySqlConnection sqlconn = new MySqlConnection(mysqlCon);
            sqlconn.Open();

            makeSql_for_meal(dzienWyswietlany);


            MySqlCommand cmd = new MySqlCommand(makeSql_for_meal(dzienWyswietlany), sqlconn);
            MySqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            sqlconn.Close();
        }

        private void foodBtn_Click(object sender, EventArgs e)
        {
            SGpanel.Visible = false;
            bmiPanel.Visible = false;
            foodPanel.Visible = true;


            String dzienWyswietlanyString = dzienWyswietlany.ToString();
            string podciag = dzienWyswietlanyString.Substring(0, Math.Min(10, dzienWyswietlanyString.Length));

            dateLabel.Text = podciag;

            //baza danych
            makeSqlDbMeals();


        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
            String mysqlCon = "server=127.0.0.1; user=root; database=hrdb; password=";
            MySqlConnection sqlconn = new MySqlConnection(mysqlCon);
            sqlconn.Open();

            String sql = "SELECT * FROM dane WHERE ID = " + id;
            MySqlCommand mySqlCommand = new MySqlCommand(sql, sqlconn);

            using (MySqlDataReader reader = mySqlCommand.ExecuteReader())
            {
                if (reader.Read()) // Sprawdzamy, czy s¹ dostêpne dane do odczytu
                {
                    string imie = reader["Imie"].ToString();
                    string waga = reader["Waga"].ToString();
                    string wzrost = reader["Wzrost"].ToString();
                    string plec = reader["Plec"].ToString();
                    string wiek = reader["wiek"].ToString();

                    if (!imie.Equals(nameTB.Text))
                    {
                        reader.Close();
                        string updateSql = "UPDATE dane SET Imie = @Imie WHERE ID = @ID";
                        MySqlCommand updateCommand = new MySqlCommand(updateSql, sqlconn);
                        updateCommand.Parameters.AddWithValue("@Imie", nameTB.Text);
                        updateCommand.Parameters.AddWithValue("@ID", id);
                        updateCommand.ExecuteNonQuery();
                    }
                    if (!waga.Equals(weightTB.Text))
                    {
                        reader.Close();
                        string updateSql = "UPDATE dane SET Waga = @Waga WHERE ID = @ID";
                        MySqlCommand updateCommand = new MySqlCommand(updateSql, sqlconn);
                        updateCommand.Parameters.AddWithValue("@Waga", weightTB.Text);
                        updateCommand.Parameters.AddWithValue("@ID", id);
                        updateCommand.ExecuteNonQuery();
                    }
                    if (!wzrost.Equals(heightTB.Text))
                    {
                        reader.Close();
                        string updateSql = "UPDATE dane SET Wzrost = @Wzrost WHERE ID = @ID";
                        MySqlCommand updateCommand = new MySqlCommand(updateSql, sqlconn);
                        updateCommand.Parameters.AddWithValue("@Wzrost", heightTB.Text);
                        updateCommand.Parameters.AddWithValue("@ID", id);
                        updateCommand.ExecuteNonQuery();
                    }
                    if (!plec.Equals(sexTB.Text))
                    {
                        reader.Close();
                        string updateSql = "UPDATE dane SET Plec = @Plec WHERE ID = @ID";
                        MySqlCommand updateCommand = new MySqlCommand(updateSql, sqlconn);
                        updateCommand.Parameters.AddWithValue("@Plec", sexTB.Text);
                        updateCommand.Parameters.AddWithValue("@ID", id);
                        updateCommand.ExecuteNonQuery();
                    }
                    if (!wiek.Equals(ageTB.Text))
                    {
                        reader.Close();
                        string updateSql = "UPDATE dane SET wiek = @wiek WHERE ID = @ID";
                        MySqlCommand updateCommand = new MySqlCommand(updateSql, sqlconn);
                        updateCommand.Parameters.AddWithValue("@wiek", ageTB.Text);
                        updateCommand.Parameters.AddWithValue("@ID", id);
                        updateCommand.ExecuteNonQuery();
                    }


                }
            }
        }

        private void label2_Click_4(object sender, EventArgs e)
        {

        }

        private void label2_Click_5(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void foodPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateLabel_Click(object sender, EventArgs e)
        {

        }

        private void addDayBtn_Click(object sender, EventArgs e)
        {
            dzienWyswietlany = dzienWyswietlany.AddDays(1);
            String dzienWyswietlanyString = dzienWyswietlany.ToString();
            string podciag = dzienWyswietlanyString.Substring(0, Math.Min(10, dzienWyswietlanyString.Length));

            dateLabel.Text = podciag;
            makeSqlDbMeals();

        }

        private void minusDayBtn_Click(object sender, EventArgs e)
        {
            dzienWyswietlany = dzienWyswietlany.AddDays(-1);
            String dzienWyswietlanyString = dzienWyswietlany.ToString();
            string podciag = dzienWyswietlanyString.Substring(0, Math.Min(10, dzienWyswietlanyString.Length));
            dateLabel.Text = podciag;
            makeSqlDbMeals();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dgv_instance = dataGridView1;
            MealForm mealForm = new MealForm();
            mealForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            makeSqlDbMeals();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dgv_instance = dataGridView1;
            Form3 deleteMeal = new Form3(MealIdGenerator.MakeMealId(dzienWyswietlany));
            deleteMeal.Show();
        }

        private void caloryLabel_Click(object sender, EventArgs e)
        {

        }
    }
}