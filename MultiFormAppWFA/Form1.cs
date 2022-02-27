using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MultiFormAppWFA
{
    public partial class Form1 : Form
    {
        static List<string> listEntries = new List<string>();
        BindingSource entriesBindingSouce = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // "links" list with data inside listBox...
            entriesBindingSouce.DataSource = listEntries;
            listBox1.DataSource = entriesBindingSouce;
        }

        private void Form1_Activated(object sender, EventArgs e) // this method is called every time Form1 is activated/re-activated
        {      
            entriesBindingSouce.ResetBindings(false); // "refresh" list 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

       internal void ReceiveData(string text)
        {
            if (text != "")
            {
                listEntries.Add(text);  // will add to list whatever text passed from Form2 textBox
            }
            
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
           
            if (i >= 0)
            {
                DialogResult result = MessageBox.Show($"Would you like to delete entry: {listEntries[i]} ?", "Confirm Delete", MessageBoxButtons.YesNo);
                if ( result == DialogResult.Yes)
                {
                    listEntries.RemoveAt(i);
                    entriesBindingSouce.ResetBindings(false);
                }            
            }            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "A -> Z")
            {
                listEntries.Sort();
            }
            else if (comboBox1.SelectedItem == "Z -> A")
            {
                listEntries.Sort();
                listEntries.Reverse();    
            }
            entriesBindingSouce.ResetBindings(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
