namespace Registration_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resultLbl.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (uname.Text != "" && pword.Text != "" && cnfPword.Text != "")
            {
                resultLbl.Text = "Registration success";
            }
            else if (cnfPword.Text != pword.Text)
            {
                resultLbl.Text = "Password doesn't Match";
            }
            else
            {
                resultLbl.Text = "Please fill all fields";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            uname.Text = string.Empty;
            pword.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}