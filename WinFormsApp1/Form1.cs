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
    }
}