namespace Assignment3_IliaBogatyrev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculate the BMI
            double weight = Convert.ToDouble(textBox1.Text);
            double height = Convert.ToDouble(textBox2.Text) / 100;
            double bmi = weight / (height * height);

            // Display the BMI
            richTextBox1.Text = String.Format("Your BMI is: {0:F2} \nStatus:", bmi);

            // Classify the BMI as underweight, optimal, or overweight
            if (bmi < 18.5)
            {
                richTextBox1.Text += " Underweight";
            }
            else if (bmi >= 18.5 && bmi <= 25)
            {
                richTextBox1.Text += " Optimal";
            }
            else
            {
                richTextBox1.Text += " Overweight";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Exit the application
            Application.Exit();
        }
    }
}