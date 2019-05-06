using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_4
{
    public partial class Form1 : Form
    {
        Circle circle;
        Cylinder cylinder;

        public Form1()
        {
            InitializeComponent();
            circle = new Circle();
            cylinder = new Cylinder();

            
            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            openFileDialog2.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            saveFileDialog2.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            circle.R = Convert.ToDouble(textBox2.Text == "" ? "0" : textBox2.Text);
            textBox5.Text = circle.ToString();

            cylinder.R = Convert.ToDouble(textBox3.Text == "" ? "0" : textBox3.Text);
            cylinder.H = Convert.ToDouble(textBox4.Text == "" ? "0" : textBox4.Text);
            textBox1.Text = cylinder.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            textBox1.Text = fileText;
            MessageBox.Show("Файл открыт");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBox1.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (saveFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog2.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, textBox5.Text);
            MessageBox.Show("Файл сохранен");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = openFileDialog2.FileName;
            // читаем файл в строку
            string fileText = System.IO.File.ReadAllText(filename);
            textBox5.Text = fileText;
            MessageBox.Show("Файл открыт");
        }
    }
}
