using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_FormatOutputBox
{
    public partial class form_Main : Form
    {
        private FormatOutputBox_GUI _outputBox = new FormatOutputBox_GUI();
        private int? _A = null;
        private int? _B = null;
        private int _index = 0;
        public form_Main()
        {
            InitializeComponent();
        }

        private void listBox_Input_SelectedIndexChanged(object sender, EventArgs e)
        {
            _index = listBox_Input.SelectedIndex;
            _outputBox.Invoke_Data(_index, ref pictureBox_Preview, ref richTextBox_Output);
        }

        private void button_Evaluate_Click(object sender, EventArgs e)
        {
            if (_A != null && _B != null)
            {
                if (_index == 4 || _index == 5)
                {
                    if (CheckAAndB(_A, _B))
                        _outputBox.Execute_Data(_A, _B);
                    else
                        MessageBox.Show("Выберите a в промежутке от 0 до 12 и b от -14 (вкл.) до 0 (вкл.)!");
                }
                else
                    _outputBox.Execute_Data(_A, _B);
            }
        }

        private void textBox_A_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (Int32.TryParse(textBox_A.Text, out value))
            {
                _A = value;
            }
            else
            {
                _A = null;
            }
        }

        private void textBox_B_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (Int32.TryParse(textBox_B.Text, out value))
            {
                _B = value;
            }
            else
            {
                _B = null; 
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            _outputBox.Clear_Data();
        }

        private bool CheckAAndB(int? a, int? b)
        {
            return 0 < a && a < 12 && -14 <= b && b <= 0;
        }
    }
}
