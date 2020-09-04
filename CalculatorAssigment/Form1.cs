using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num, ans;
        int count;

        public void disable()
        {
            // calculator off

            textBox1.Enabled = false;
            button1.Show();
            button2.Hide();
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;            
            button19.Enabled = false;
            button20.Enabled = false; 
            button21.Enabled = false;          

        }

        public void enable()
        {
            // calculator off

            textBox1.Enabled = true;
            button1.Hide();
            button2.Show();
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e) //  333333
        {
            textBox1.Text = textBox1.Text + 3;
            textBox1.ForeColor = Color.Black;
        }

        private void button20_Click(object sender, EventArgs e) // .
        {
            textBox1.Text = textBox1.Text + ".";
            textBox1.ForeColor = Color.Black;
        }

        private void button21_Click(object sender, EventArgs e) // 0000
        {
            textBox1.Text = textBox1.Text + 0;
            textBox1.ForeColor = Color.Black;
        }

        private void button17_Click(object sender, EventArgs e) // 11111
        {
            textBox1.Text = textBox1.Text + 1;
            textBox1.ForeColor = Color.Black;
        }

        private void button16_Click(object sender, EventArgs e) // 2222
        {
            textBox1.Text = textBox1.Text + 2;
            textBox1.ForeColor = Color.Black;
        }

        private void button13_Click(object sender, EventArgs e) // 4444
        {
            textBox1.Text = textBox1.Text + 4;
            textBox1.ForeColor = Color.Black;
        }

        private void button12_Click(object sender, EventArgs e) // 555555
        {
            textBox1.Text = textBox1.Text + 5;
            textBox1.ForeColor = Color.Black;
        }

        private void button11_Click(object sender, EventArgs e) //666666
        {
            textBox1.Text = textBox1.Text + 6;
            textBox1.ForeColor = Color.Black;
        }

        private void button6_Click(object sender, EventArgs e) //777777
        {
            textBox1.Text = textBox1.Text + 7;
            textBox1.ForeColor = Color.Black;
        }

        private void button7_Click(object sender, EventArgs e) // 8888888
        {
            textBox1.Text = textBox1.Text + 8;
            textBox1.ForeColor = Color.Black;
        }

        private void button9_Click(object sender, EventArgs e) //9999999
        {
            textBox1.Text = textBox1.Text + 9;
            textBox1.ForeColor = Color.Black;
        }






        private void button2_Click(object sender, EventArgs e) 
        {
            disable();                   // off button
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enable();                    // on button
        }





        private void button5_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";  // display + sign

        }

        private void button8_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";  // display - sign
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
            label1.Text = num.ToString() + "*";  // display * sign
        }

        private void button14_Click(object sender, EventArgs e)
        {
            num = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";  // display / sign
        }

        private void button19_Click(object sender, EventArgs e)
        {
            compute();                       // = button
            label1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";    // CE clear button
        }

        private void button3_Click(object sender, EventArgs e)  // C button
        {
            textBox1.Clear();
            num = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e) // pondt to kgs convert
        {
            double Pound = (double)numericUpDown1.Value;
            double Answer = Pound * 0.453592;
            label6.Text = Answer.ToString() + "KGs";
        }

        private void button22_Click(object sender, EventArgs e) // kgs to pound convert
        {
            double KG = (double)numericUpDown2.Value;
            double Answer2 = KG * 2.20462;
            label6.Text = Answer2.ToString() + "Pounds";
        }

        private void button25_Click(object sender, EventArgs e) // Reset button
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            label6.Text = "Answer:";
        }

        private void button23_Click(object sender, EventArgs e) // miles to kilometer
        {
            double Mile = (double)numericUpDown3.Value;
            double Answer = Mile * 1.60934;
            label6.Text = Answer.ToString() + "KiloMeters";
        }

        private void button24_Click(object sender, EventArgs e) // kilometer to miles
        {
            double KiloMeter = (double)numericUpDown4.Value;
            double Answer = KiloMeter * 0.621371;
            label6.Text = Answer.ToString() + "Miles";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void compute()  // calculation
        {
            switch (count)
            {
                case 1:
                    ans = num + float.Parse(textBox1.Text);  // +
                    textBox1.Text = ans.ToString();          // float into string
                    break;

                case 2:
                    ans = num - float.Parse(textBox1.Text);  // -
                    textBox1.Text = ans.ToString();          // float into string
                    break;

                case 3:
                    ans = num * float.Parse(textBox1.Text);  // *
                    textBox1.Text = ans.ToString();          // float into string
                    break;

                case 4:
                    ans = num / float.Parse(textBox1.Text);  // /
                    textBox1.Text = ans.ToString();          // float into string
                    break;

                default:
                    break;



            }
        }
    }
}
