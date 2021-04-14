using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hello_world_win_form
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        /*
         * Click "Clike Here" will change text to "Hello World"
         */
        private void hello_click(object sender, EventArgs e)
        {
            //Clicking "Click Here" changes text to "Hello world"

            //hello_label.Text = "Hello World";


            //Click changes text to sum of 3
            int sum = 1 + 2;

            hello_label.Text = sum.ToString();


        }
    }
}
