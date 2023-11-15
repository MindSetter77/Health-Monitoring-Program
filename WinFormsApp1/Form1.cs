using System.Xml.Serialization;

using MySql.Data.MySqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loginPanel.Visible = false;
            registerPanel.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            choosePanel.Visible = false;
            loginPanel.Visible = true;

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

            String mysqlCon = "server=127.0.0.1; user=root; database=hrdb; password=";
            MySqlConnection sqlconn = new MySqlConnection(mysqlCon);
            try
            {
                sqlconn.Open();
                if(String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Uzupe³nij wszystkie pola");
                }
                else
                {
                    MySqlCommand mySqlCommand = new MySqlCommand("select * from users", sqlconn);
                    MySqlDataReader reader = mySqlCommand.ExecuteReader();
                    Boolean logged = false;
                    while(reader.Read())
                    {
                        if (login.Equals(reader.GetString("username")) && password.Equals(reader.GetString("password")))
                        {
                            logged = true;
                        }
                    }
                    if (logged == false)
                    {
                        MessageBox.Show("Nie rozpoznano u¿ytkownika");
                    }
                    else
                    {
                        MessageBox.Show("Zalogowano jako " + login);
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


            textBox1.Text = "";
            textBox2.Text = "";

        }
    }
}