using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gunsonuquickpractice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String isl = comboBox1.Text;

            switch (isl)
            {
                case "ÇARP": textBox3.Text = "*"; break;
                case "BÖL": textBox3.Text = "/"; break;
                case "TOPLA": textBox3.Text = "+"; break;
                case "ÇIKAR": textBox3.Text = "-"; break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = listBox2.SelectedItem.ToString();
        }
        int i = 1;
        private void Form1_Load(object sender, EventArgs e)
        {
            for(i=i; i<100; i++)
            {
                if (i%2 == 0)
                {
                    listBox2.Items.Add(i);
                }
                else if (i % 2 != 0)
                {
                    listBox1.Items.Add(i);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int bi = int.Parse(textBox1.Text);
            int ki = int.Parse(textBox2.Text);
            String isl = comboBox1.Text;
            int son;
            switch (isl)
            {
                case "ÇARP": son = bi * ki; listBox3.Items.Add(bi + "*" + ki + "=" + son.ToString()); break;
                case "BÖL": son = bi / ki; listBox3.Items.Add(bi + "/" + ki + "=" + son.ToString()); break;
                case "TOPLA": son = bi + ki; listBox3.Items.Add(bi + "+" + ki + "=" + son.ToString()); break;
                case "ÇIKAR": son = bi - ki; listBox3.Items.Add(bi + "-" + ki + "=" + son.ToString()); break;
            }

            int say = listBox3.Items.Count;
            label6.Text = say.ToString();



        }
    }
}


