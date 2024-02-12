using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_1
{
    public partial class Form1 : Form
    {
        public Calcuator calcuator = new Calcuator();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                calcuator.state = 1;
                calcuator.undoValue = float.Parse(textBox1.Text);
                textBox1.Text = "";
            }
            catch (Exception exx)
            {

                textBox1.Text = exx.Message;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {

            try
            {
                calcuator.state = 2;
                calcuator.undoValue = float.Parse(textBox1.Text);
                textBox1.Text = "";
            }
            catch (Exception exx)
            {

                textBox1.Text = exx.Message;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                calcuator.state = 3;
                calcuator.undoValue = float.Parse(textBox1.Text);
                textBox1.Text = "";
            }
            catch (Exception exx)
            {

                textBox1.Text = exx.Message;
            }

        }

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                calcuator.state = 5;
                calcuator.undoValue = float.Parse(textBox1.Text);
                textBox1.Text = "";
            }
            catch (Exception exx)
            {

                textBox1.Text = exx.Message;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                calcuator.state = 6;
                calcuator.undoValue = float.Parse(textBox1.Text);
                textBox1.Text = "";
            }
            catch (Exception exx)
            {

                textBox1.Text = exx.Message;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calcuator.state = 7;
            calcuator.AddInHistory(float.Parse(textBox1.Text), calcuator);
            textBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calcuator.state = 8;
            textBox1.Text = calcuator.OutInHistory(calcuator);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                calcuator.state = 4;
                calcuator.undoValue = float.Parse(textBox1.Text);
                textBox1.Text = "";
            }
            catch (Exception exx)
            {

                textBox1.Text = exx.Message;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                calcuator.state = 2;
                calcuator.undoValue = float.Parse(textBox1.Text);
                textBox1.Text = "";
            }
            catch (Exception exx)
            {

                textBox1.Text = exx.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                switch (calcuator.state)
                {
                    case 1:
                        {
                            textBox1.Text = calcuator.Plus(calcuator.undoValue, float.Parse(textBox1.Text)).ToString();
                            break;
                        }
                    case 2:
                        {
                            textBox1.Text = calcuator.Minus(calcuator.undoValue, float.Parse(textBox1.Text)).ToString();
                            break;
                        }
                    case 3:
                        {
                            textBox1.Text = calcuator.Devision(calcuator.undoValue, float.Parse(textBox1.Text)).ToString();
                            break;
                        }
                    case 4:
                        {
                            textBox1.Text = calcuator.Multiplication(calcuator.undoValue, float.Parse(textBox1.Text)).ToString();
                            break;
                        }
                    case 5:
                        {
                            textBox1.Text = calcuator.Percent(calcuator.undoValue, float.Parse(textBox1.Text)).ToString();
                            break;
                        }
                    case 6:
                        {
                            textBox1.Text = calcuator.WithoutOstatok(calcuator.undoValue, float.Parse(textBox1.Text)).ToString();
                            break;
                        }
                    default:
                        break;
                }
            }
            catch (Exception exx)
            {
                textBox1.Text = exx.Message;
                
            }
        }
    }
}
