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
        private int[] numbersArray;
        public Form1()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int size = random.Next(10, 21);
            numbersArray = new int[size];

            for (int i = 0; i < size; i++)
            {
                numbersArray[i] = random.Next(-100, 101);
            }

            arrayTextBox.Text = string.Join(", ", numbersArray);
            analyzeButton.Enabled = true;
            countTextBox.Clear();
            resultListBox.Items.Clear();
        }

        private void analyzeButton_Click(object sender, EventArgs e)
        {
            if (numbersArray == null || numbersArray.Length == 0)
            {
                MessageBox.Show("Сначала сгенерируйте массив!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int count = 0;
            List<int> greaterElements = new List<int>();

            for (int i = 1; i < numbersArray.Length; i++)
            {
                if (numbersArray[i] > numbersArray[i - 1])
                {
                    count++;
                    greaterElements.Add(numbersArray[i]);
                }
            }

            countTextBox.Text = count.ToString();
            resultListBox.Items.Clear();

            foreach (int num in greaterElements)
            {
                resultListBox.Items.Add(num);
            }
        }
    }
}
