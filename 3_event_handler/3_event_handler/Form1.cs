using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_event_handler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void do_sum_Click(object sender, EventArgs e)
        {
            string result = addition(num_1.Text, num_2.Text);

            sum_result.Text = result;
        }

        public string addition(string num1, string num2) 
        {
            int number_1 = Convert.ToInt32(num1);
            int number_2 = Convert.ToInt32(num2);

            return (number_1 + number_2).ToString();
        }
    }
}
