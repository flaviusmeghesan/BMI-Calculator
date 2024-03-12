namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double age = Convert.ToDouble(textBox2.Text);
            double height = Convert.ToDouble(textBox4.Text);
            double weight = Convert.ToDouble(textBox3.Text);

            double calories = 0.0;
            if (radioButton1.Checked)

                calories = (10 * weight) + (6.25 * height) - (5 * age) + 5;

            else if (radioButton2.Checked)

                calories = (10 * weight) + (6.25 * height) - (5 * age) - 161;

            textBox1.Text = "Calories intake: " + Environment.NewLine + calories.ToString("#.#") + " Kcal.";
        }
    }
}
