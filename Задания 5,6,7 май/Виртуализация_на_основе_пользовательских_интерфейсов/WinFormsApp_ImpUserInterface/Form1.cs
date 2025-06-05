using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp_ImpUserInterface
{
    public partial class form_Main: Form
    {
        private bool _flag_access = true;
        private const int defaultNum = 15;
        private readonly int[] _paramValuesDefault = { defaultNum, defaultNum + 1, defaultNum + 2};
        private IEvaluate[] _evaluate_ref = { null, null, null };
        private int currentVscrollValue = 0;
        public form_Main()
        {
            InitializeComponent();
            _evaluate_ref[0] = new Class_Task1();
            _evaluate_ref[1] = new Class_Task2();
            _evaluate_ref[2] = new Class_Task3();
            comboBox_TaskNum.SelectedIndex = 0;
        }

        private void comboBox_TaskNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_flag_access) return;
            int ind = comboBox_TaskNum.SelectedIndex;
            _evaluate_ref[ind].Invoke_Variant(ind, currentVscrollValue);
            pictureBox_Formula.Image = (Image)Properties.Resources.ResourceManager.GetObject($"Task_{(ind + 1).ToString()}");
        }
        private void button_EvaluateVariant_Click(object sender, EventArgs e)
        {
            if (!_flag_access) return;
            int ind = comboBox_TaskNum.SelectedIndex;
            string str_out = _evaluate_ref[ind].Execute_Variant();
            label_Output.Text = str_out;
        }

        private void label_Output_TextChanged(object sender, EventArgs e)
        {
            if (!_flag_access) return;
            int ind = comboBox_TaskNum.SelectedIndex;
            string str_num = textBox_InputValue.Text;
            _evaluate_ref[ind].ParamValue = Int32.Parse(str_num);
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_EvaluateAllDefault_Click(object sender, EventArgs e)
        {
            if (!_flag_access) return;
            int ind = comboBox_TaskNum.SelectedIndex;
            _evaluate_ref[ind].Invoke_Variant(ind, _paramValuesDefault[ind]);
            string str_out = _evaluate_ref[ind].Execute_Variant();
            label_Output.Text = $"Значение по умолчанию: {_paramValuesDefault[ind]}\n" + str_out;
        }

        private void vScrollBar_InputValue_Scroll(object sender, ScrollEventArgs e)
        {
            currentVscrollValue = vScrollBar_InputValue.Maximum - vScrollBar_InputValue.Value;
            textBox_InputValue.Text = currentVscrollValue.ToString();
        }

        private void form_Main_Load(object sender, EventArgs e)
        {
            textBox_InputValue.Text = "0";
        }

        private void pictureBox_Formula_Click(object sender, EventArgs e)
        {

        }
    }
}
