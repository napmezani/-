using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_ImpUserInterface
{
    class Class_Task2 : IEvaluate
    {
        public int NumOfVariant { get; set; }
        public int ParamValue { get; set; }
        public void Invoke_Variant(int numOfVariant, int paramValueDefault)
        {
            NumOfVariant = numOfVariant;
            ParamValue = paramValueDefault; 
        }
        public string Execute_Variant()
        {
            string str_paramValue = ParamValue.ToString();
            string str = "Новое число: ";
            for (int i = 0; i < str_paramValue.Length; i++)
            {
                if ((int)(str_paramValue[i]) % 2 == 0)
                    str += '0';
                else
                    str += str_paramValue[i];
            }
            return str;
        }
    }
}
