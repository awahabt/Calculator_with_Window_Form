using System.Configuration;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addNumber_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            float c = a + b;
            result.Text = c.ToString();
            result.Visible = true;
        }

        private void subtNumber_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            float c = a - b;
            result.Text = c.ToString();
            result.Visible = true;
        }

        private void multiNumber_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            float c = a * b;
            result.Text = c.ToString();
            result.Visible = true;
        }

        private void divideNumber_Click(object sender, EventArgs e)
        {
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            float c = a / b;
            result.Text = c.ToString();
            result.Visible = true;
        }
    }
}
