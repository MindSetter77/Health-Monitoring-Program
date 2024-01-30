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
    public partial class Form3 : Form
    {
        String dayId;

        public Form3(String dayId)
        {
            InitializeComponent();
            this.dayId = dayId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(dayId);

            string mysqlCon = "server=127.0.0.1; user=root; database=hrdb; password=";
            MySqlConnection sqlconn = new MySqlConnection(mysqlCon);
            sqlconn.Open();

            string query = "DELETE FROM meal WHERE user_id = 0";

            MySqlCommand cmd = new MySqlCommand(query, sqlconn);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
