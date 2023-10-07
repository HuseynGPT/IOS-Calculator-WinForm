namespace IOS_Calculator
{
    public partial class Form1 : Form
    {


        int number_1, number_2, result;
        string operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Number Buttons Click
        private void Number_0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) { }
            else
                textBox1.Text = textBox1.Text + "0";
        }

        private void Number_1_Click(object sender, EventArgs e) =>
            textBox1.Text = textBox1.Text + "1";

        private void Number_2_Click(object sender, EventArgs e) =>
                        textBox1.Text = textBox1.Text + "2";

        private void Number_3_Click(object sender, EventArgs e) =>
            textBox1.Text = textBox1.Text + "3";

        private void Number_4_Click_1(object sender, EventArgs e) =>
                        textBox1.Text = textBox1.Text + "4";
        private void Number_5_Click(object sender, EventArgs e) =>
                        textBox1.Text = textBox1.Text + "5";

        private void Number_6_Click_2(object sender, EventArgs e) =>
                        textBox1.Text = textBox1.Text + "6";

        private void Number_7_Click_1(object sender, EventArgs e) =>
                        textBox1.Text = textBox1.Text + "7";

        private void Number_8_Click(object sender, EventArgs e) =>
                        textBox1.Text = textBox1.Text + "8";

        private void Number_9_Click_1(object sender, EventArgs e) =>
                        textBox1.Text = textBox1.Text + "9";
        #endregion Number Buttons Click


        private void clearC_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            number_1 = 0;
            number_2 = 0;
            result = 0;


        }

        private void divide_Click(object sender, EventArgs e)
        {
            operation = "/";

            number_1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            operation = "*";

            number_1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operation = "-";

            number_1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void plus_Click(object sender, EventArgs e)
        {
            operation = "+";

            number_1 = int.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            number_2 = int.Parse(textBox1.Text);

            if (operation == "+")
                result = number_1 + number_2;
            if (operation == "-")
                result = number_1 - number_2;
            if (operation == "*")
                result = number_1 * number_2;
            if (operation == "/")
            {
                if (number_2 == 0)
                    MessageBox.Show("Cannot divide zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    result = number_1 / number_2;
            }

            textBox1.Text = result.ToString();
        }

        private void circularButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon....");
        }

        private void Percentage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon....");
        }

        private void circularButton19_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon....");
        }
    }
}