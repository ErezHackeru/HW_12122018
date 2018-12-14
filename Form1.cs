using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HW_1212
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int upperLimit;
            int lowerLimit;
            if (!Int32.TryParse(textBox1.Text, out upperLimit))
                label1.Text = "textbox 1 was wrong input";
            else if (!Int32.TryParse(textBox2.Text, out lowerLimit))
                label1.Text = "textbox 2 was wrong input";
            else
            {
                //int upperLimit = Convert.ToInt16(textBox1.Text);
                //int lowerLimit = Convert.ToInt16(textBox2.Text);
                int NumToPut = rnd.Next(upperLimit, lowerLimit + 1);
                Debug.WriteLine($"The new number random is: {NumToPut}");
                Debug.WriteLine($"The number in Textbx 1 is: {upperLimit}");
                Debug.WriteLine($"The number in Textbx 2 is: {lowerLimit}");
                label1.Text = $"The new number random is: {NumToPut}";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
        }
    }
}
