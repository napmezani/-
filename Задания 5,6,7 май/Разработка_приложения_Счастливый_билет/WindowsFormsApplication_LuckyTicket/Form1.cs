using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using evaluate = WindowsFormsApplication_LuckyTicket.lt_Evaluation.Class_Evaluating;
using parse = WindowsFormsApplication_LuckyTicket.lt_Evaluation.Class_Parsing;

namespace WindowsFormsApplication_LuckyTicket
{
    public partial class Form_Main: Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_CheckVariant_Click(object sender, EventArgs e)
        {
            short[] arr = { -1, -1, -1, -1, -1, -1 };
            short def = -1;

            string str_arr = this.textBox_Input.Text;
            long lg_count = str_arr.Count();
            for (long lg_i = 0; lg_i < lg_count; lg_i++)
            {
                if (lg_i == 6)
                    break;
                string str = str_arr.ElementAt((int)lg_i).ToString();
                arr[lg_i] = (short)parse.StrToShortDef(str, def);
            }

            short sh_checked = evaluate.DEF_VARIANT_DEFAULT;

            if (this.radioButton_VariantTask.Checked)
                sh_checked = evaluate.DEF_VARIANT_TASK;

            short sh_answer = evaluate.IsHappyLucky(arr, sh_checked);
            string str_answer = evaluate.GetMessageByLuckyValue(sh_answer);
            MessageBox.Show(str_answer);
        }

        private void button_FindAllLucky_Click(object sender, EventArgs e)
        {
            short sh_checked = evaluate.DEF_VARIANT_DEFAULT;
            if (this.radioButton_VariantTask.Checked)
                sh_checked = evaluate.DEF_VARIANT_TASK;

            List<string> lst_lucky = new List<string>();
            lst_lucky.Clear();
            short[] sh_arr = { 1, -1, -1, -1, -1, -1 };

            long lg_count_i = 0;
            for (long lg_i = 0; lg_i <= 999999; lg_i += 111111)
            {
                parse.ConvertLongToArray(lg_i, ref sh_arr);
                short sh_answer = evaluate.IsHappyLucky(sh_arr, sh_checked);
                if (sh_answer == evaluate.DEF_LUCKY_TICKET)
                {
                    string str = "[" + lg_count_i.ToString() + "] " + parse.ConvertLongToString(lg_i, 6);
                    lst_lucky.Add(str);
                    lg_count_i++;
                }
            }

            listBox_Enumerate.Items.Clear();
            listBox_Enumerate.Items.AddRange(lst_lucky.ToArray());
        }
    }
}
