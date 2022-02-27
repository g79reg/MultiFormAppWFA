using System;
using System.Windows.Forms;

namespace MultiFormAppWFA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); 
            if (!String.IsNullOrWhiteSpace(textBox1.Text))
            {
                form1.ReceiveData(textBox1.Text);
                this.Close();
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Wrong format! Please fill in the box...");
            }   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
