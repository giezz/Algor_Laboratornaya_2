using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int rightCount = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) rightCount++;
            if (radioButton5.Checked == true) rightCount++;
            if (radioButton12.Checked == true) rightCount++;
            if (radioButton15.Checked == true) rightCount++;
            if (radioButton18.Checked == true) rightCount++;

            label6.Text = "Резульат: " + rightCount + " из 5";
            rightCount = 0;
        }
    }
}
