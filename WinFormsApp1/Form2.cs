using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private string makeMealId(DateTime time)
        {
            int[] desiredPositions = { 0, 1, 3, 4, 6, 7, 8, 9 };
            string result = "";

            string originalString = time.ToString();

            foreach (var position in desiredPositions)
            {
                if (position < originalString.Length) // Sprawdź, czy pozycja nie wykracza poza długość stringa
                {
                    result += originalString[position]; // Dodaj znak z danej pozycji do wyniku
                }
            }


            return result;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dz = Form1.instance.dzienWyswietlany;
            string id = makeMealId(dz);
            

            String posilekStr = posilek.Text;

            try
            {
                int kalorieInt = Int32.Parse(kalorie.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("error: " + ex.Message);
                return;
            }
            


            // Connection string to connect to the database
            String mysqlCon = "server=127.0.0.1; user=root; database=hrdb; password=";
            MySqlConnection sqlconn = new MySqlConnection(mysqlCon);
            try
            {
                
                sqlconn.Open(); // Open the connection

                int midn = Form1.instance.dgv_instance.RowCount;

                // Here, you should put your INSERT statement and the necessary data you wish to insert
                string sql = "INSERT INTO meal (user_id, date_id, meal_in_day_number, meal, calories) VALUES (0, "+id+", "+midn.ToString()+", '"+posilekStr+"', "+kalorie.Text+")";

                // Create a command object
                MySqlCommand cmd = new MySqlCommand(sql, sqlconn);

                // Execute the command
                cmd.ExecuteNonQuery();

                // Optionally, inform the user of success
                
                Form1.instance.RunMakeSqlDbMeals();
            }
            catch (MySqlException ex)
            {
                // Handle any errors that occur during the insert
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                if (sqlconn != null && sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close(); // Close the connection when done
                }
                this.Close();
            }
        }

    }
}
