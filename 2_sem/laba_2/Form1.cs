using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace laba_2
{
    public partial class Form1 : Form
    {
        ToolStripLabel dateLabel;
        ToolStripLabel timeLabel;
        ToolStripLabel infoLabel;
        Timer timer;

        private List<Airplane> airplaneList = new List<Airplane>();
        int id = 1;
        public Airplane airplane = new Airplane();
        public Form1()
        {
            InitializeComponent();
            File.Delete("dataSort.xml");
            infoLabel = new ToolStripLabel();
            dateLabel = new ToolStripLabel();
            timeLabel = new ToolStripLabel();

            statusStrip1.Items.Add(infoLabel);
            statusStrip1.Items.Add(dateLabel);
            statusStrip1.Items.Add(timeLabel);

            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer1_Tick;
            timer.Start();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(textBox4.Text) < 0 )
                {
                    throw new Exception("maxWeight не входит в диапозон значений");
                }
                airplane.maxWeight = Int32.Parse(textBox4.Text);
                airplane.dateOfLastOsmotr = Convert.ToInt32(textBox3.Text);
                airplane.dateOfCreate = Int32.Parse(textBox2.Text);
                if (listBox1.SelectedItem != null)
                {
                    airplane.countOfPlace = Int32.Parse(listBox1.SelectedItem.ToString());
                }
                else
                {
                    airplane.countOfPlace = default(int);
                }
                if (comboBox1.SelectedItem != null)
                {
                    airplane.type = comboBox1.SelectedItem.ToString();
                }
                else
                {
                    airplane.type = "no";
                }
                airplane.Id = id;
                airplane.model = textBox1.Text;
                using (StreamWriter file = new StreamWriter("dates.xml", true))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Airplane));
                    serializer.Serialize(file, airplane);
                }
                airplaneList.Add(airplane);
                airplane = new Airplane();
                id++;
                label5.Text = (id-1).ToString();
                label2.ForeColor = Color.Green;
                label2.Text = "Success";
                label6.Text = "added element";
            }
            catch (Exception ex)
            {
                label2.ForeColor = Color.Red;
                label2.Text = ex.Message;
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ekipash_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox3.Text = "";
        }

        private void textBox4_MouseClick(object sender, MouseEventArgs e)
        {
            textBox4.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void датеПоследнегоТехОбслуживанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = "Сортировка по дате тех обс";
            richTextBox1.Text = "";
            label3.Text = "Sorted by year of create";
            StreamWriter writer = new StreamWriter("dataSort.xml", true);
            XmlSerializer serializer = new XmlSerializer(typeof(Airplane));
            if (airplaneList.Count != 0)
            {
                var sortedList = from item in airplaneList orderby item.dateOfLastOsmotr ascending select item;
                foreach (var item in sortedList)
                {
                    richTextBox1.Text += "id: " + item.Id.ToString() + "model: " + item.model.ToString() + "\n";
                    serializer.Serialize(writer, item);
                }
            }
            else
            {
                richTextBox1.Text = "Ангар пуст";
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 1.1\nDeveloper: Lomako Alexandr Dmitrievich","info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void годуВыпускаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = "Сортировка по году Выпуска";
            richTextBox1.Text = "";
            StreamWriter writer = new StreamWriter("dataSort.xml", true);
            XmlSerializer serializer = new XmlSerializer(typeof(Airplane));
            label3.Text = "Sorted by year of create";
            if (airplaneList.Count != 0)
            {
                var sortedList = from item in airplaneList orderby item.dateOfCreate ascending select item;
                foreach (var item in sortedList)
                {
                    richTextBox1.Text += "id: " + item.Id.ToString() + "model: " + item.model.ToString() + "\n";
                    serializer.Serialize(writer, item);
                }
            }
            else
            {
                richTextBox1.Text = "Ангар пуст";
            }
         
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void авиакомпанииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = "Поиск по моделе";
            bool contain = false;
            richTextBox1.Text = "";
            Form3 frm = new Form3();
            frm.ShowDialog();
            Regex regex = new Regex(frm.regex);
            StreamWriter writer = new StreamWriter("dataSort.xml", true);
            XmlSerializer serializer = new XmlSerializer(typeof(Airplane));
            foreach (var item in airplaneList)
            {
                MatchCollection matchCollection = regex.Matches(item.model.ToString());
                if (matchCollection.Count != 0)
                {
                    contain = true;
                    richTextBox1.Text += "id: " + item.Id.ToString() + " model: " + item.model.ToString() + " type: " + item.type.ToString() + "\n";
                    serializer.Serialize(writer, item);
                }
            }
            if (!contain)
            {
                richTextBox1.Text = "No elements";
            }
            
        }

        private void типуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = "Поиск по типу";
            StreamWriter writer = new StreamWriter("dataSort.xml", true);
            XmlSerializer serializer = new XmlSerializer(typeof(Airplane));
            bool contain = false;
            richTextBox1.Text = "";
            Form3 frm = new Form3();
            frm.ShowDialog();
            Regex regex = new Regex(frm.regex);
            foreach (var item in airplaneList)
            {
                MatchCollection matchCollection = regex.Matches(item.type.ToString());
                if (matchCollection.Count != 0)
                {
                    contain= true;
                    richTextBox1.Text += "id: " + item.Id.ToString() + " model: " + item.model.ToString() + " type: " + item.type.ToString()+"\n";
                    serializer.Serialize(writer, item);
                }
            }
            if (!contain)
            {
                richTextBox1.Text = "No elements";
            }
        }

        private void количествуМестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = "Поиск по кол-ву мест";
            StreamWriter writer = new StreamWriter("dataSort.xml", true);
            XmlSerializer serializer = new XmlSerializer(typeof(Airplane));
            bool contain = false;
            richTextBox1.Text = "";
            Form3 frm = new Form3();
            frm.ShowDialog();
            Regex regex = new Regex(frm.regex);
            foreach (var item in airplaneList)
            {
                MatchCollection matchCollection = regex.Matches(item.countOfPlace.ToString());
                if (matchCollection.Count != 0)
                {
                    contain = true;
                    richTextBox1.Text += "id: " + item.Id.ToString() + " model: " + item.model.ToString() + " type: " + item.type.ToString() + "\n";
                    serializer.Serialize(writer, item);
                }
            }
            if (!contain)
            {
                richTextBox1.Text = "No elements";
            }
        }

        private void грузоподъемностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = "Поиск по грузоподъемности";
            StreamWriter writer = new StreamWriter("dataSort.xml", true);
            XmlSerializer serializer = new XmlSerializer(typeof(Airplane));
            bool contain = false;
            richTextBox1.Text = "";
            Form3 frm = new Form3();
            frm.ShowDialog();
            Regex regex = new Regex(frm.regex);
            foreach (var item in airplaneList)
            {
                MatchCollection matchCollection = regex.Matches(item.maxWeight.ToString());
                if (matchCollection.Count != 0)
                {
                    contain = true;
                    richTextBox1.Text += "id: " + item.Id.ToString() + " model: " + item.model.ToString()+ " type: " + item.type.ToString() + "\n";
                    serializer.Serialize(writer, item);
                }
            }
            if (!contain)
            {
                richTextBox1.Text = "No elements";
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToLongDateString();
            timeLabel.Text = DateTime.Now.ToLongTimeString();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (toolStrip1.Visible == true)
            {
                button2.Text = "Показать панель";
                toolStrip1.Hide();
            }
            else
            {
                button2.Text = "Скрыть панель";
                toolStrip1.Show();
            }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
    
