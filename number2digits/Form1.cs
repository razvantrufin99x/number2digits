using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace number2digits
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int number = 0;

        public void convert2digits()
        { 
            while(number > 0)
            {
                textBox2.Text += (number % 10).ToString() + "\r\t";
                textBox2.Text += (number / 10).ToString() + "\r\n";
                number = number / 10;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number = Convert.ToInt32(textBox1.Text);
            convert2digits();
        }
    }
}
