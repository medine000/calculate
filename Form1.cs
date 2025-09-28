namespace calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            double number1 = Convert.ToDouble(maskedTextBox1.Text);
            double number2 = Convert.ToDouble(maskedTextBox2.Text);
            string operation = comboBox1.SelectedItem.ToString();
            double result = 0;

            if(operation == "+")
            {
                result = number1 + number2;
            }
            else if(operation == "-")
            {
                result = number1 - number2;
            }
            else if(operation == "*")
            {
                result = number1 * number2;
            }
            else if(operation == "/")
            {
                if(number2 != 0)
                {
                    result = number1 / number2;
                }
                else
                {
                    MessageBox.Show("Cannot divide by zero.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a valid operation.");
                return;
            }
            listBox1.Items.Add(number1+ "" + operation+ "" +number2+ "=" + result);
        }
    }
}
