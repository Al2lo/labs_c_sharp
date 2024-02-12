using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace laba_2
{
    public partial class Form2 : Form
    {
        Form1 form1 = (Form1)Form1.ActiveForm;
        PersonOfEcipash personOfEcipash = new PersonOfEcipash();

        
       

        public Form2()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                personOfEcipash.lastname = textBox3.Text;
                personOfEcipash.surname = textBox2.Text;
                personOfEcipash.name = textBox1.Text;
                if (comboBox1.SelectedItem != null)
                {
                    personOfEcipash.zvanie = (comboBox2.SelectedItem.ToString());
                }
                else
                {
                    personOfEcipash.zvanie = default(string);
                }
                if (comboBox2.SelectedItem != null)
                {
                    personOfEcipash.countOfAge = Int32.Parse(comboBox2.SelectedItem.ToString());
                }
                else
                {
                    personOfEcipash.countOfAge = default(int);
                }

                form1.airplane.ekipash.Add(personOfEcipash);
                this.Close();

            }
            catch (Exception ex)
            {
                label1.ForeColor = Color.Red;
                label1.Text = ex.Message;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
