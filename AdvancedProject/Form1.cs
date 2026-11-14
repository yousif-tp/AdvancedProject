namespace AdvancedProject
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int shift = ((int)numericUpDown1.Value) % 26;
            String input = (textBox1.Text).ToLower();
            String output = "";

            foreach (char c in input) { 
                int neww = c;
                //Shifting logic
                if (c >=97 && c <= 122)
                {
                    neww = c + shift;
                    if (neww > 122)
                    {
                        neww -= 26;
                    }

                }

                output += (char)neww;
            }

            textBox2.Text = output;

        }
    }
}
