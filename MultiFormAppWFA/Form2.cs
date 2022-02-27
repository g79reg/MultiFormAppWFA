using System;
using System.Windows.Forms;

namespace MultiFormAppWFA
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ReceiveData(textBox1.Text);
            this.Close();
        }
    }
}
