namespace CalenderMonth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dayLbl.Text = dateTimePicker1.Value.Date.ToString();
            monthLbl.Text = dateTimePicker1.Value.Month.ToString();
            yearLbl.Text = dateTimePicker1.Value.Year.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lowerRad.Checked)
            {
                resultLbl.Text = caseTxt.Text.ToLower();
            }
            else if (upperRad.Checked)
            {
                resultLbl.Text = caseTxt.Text.ToUpper();
            }
            else
            {
                MessageBox.Show("Please Select Any of the options");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dayLbl.Text = string.Empty;
            monthLbl.Text = string.Empty;
            yearLbl.Text = string.Empty;
            resultLbl.Text = string.Empty;
        }
    }
}