namespace Login_Form
{
    public partial class Form1 : Form
    {
        const string USERNAME = "John";
        const string PASSWORD = "John@Ria";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resultLbl.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uname.Text == USERNAME && pword.Text == PASSWORD)
            {
                resultLbl.Text = "✅ Username and password is correct";
            }
            else
            {
                resultLbl.Text = "❌ Username/Password is in correct";
            }
        }
    }
}