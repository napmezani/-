using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime value = dateTimePicker1.Value;
            string[] formats = new string[]
            {
                "dddd",
                "dd",
                "F",
                "f",
                "D",
                "dd.MM.yyyy",
                "t",
                "g",
                "G",
                "MMMM",
            };
            AddMessageToLog(value, formats);
        }
        private void AddMessageToLog(DateTime value, string[] formats)
        {
            foreach (string format in formats)
            {
                richTextBox1.Text += "Дата и время в формате '" + format + "':\r\n\t" + value.ToString(format) + "\r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}
