namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
        int value = 0;

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = "unverified";
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "verified";
            }
            else
            {
                checkBox1.Text = "unverified";
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox1.Text != " " && textBox2.Text != " " && textBox3.Text != " ")
            {
                if (textBox1.Text.Length >= 5 && textBox2.Text.Length >= 7 && textBox3.Text.Length >= 5)
                {
                    MessageBox.Show($"Hello {textBox3.Text} sucessfully logged in.");
                    SharedData.TextBoxValue = textBox3.Text;
                    SharedData.TextEmailValue = textBox2.Text;
                    Form2 Check = new Form2();
                    Check.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Error due to invalid username or password or email username and email must have atleast 5 charecters and password must have atleat 7 charecters with special charectrs");
                }
                
            }
            else
            {
                MessageBox.Show($"value :error fill every column properly and login please");
            }
            
        }
        public class SharedData
        {
            public static string TextBoxValue { get; set; }
            public static string TextEmailValue { get; set; }
        }
    }
}