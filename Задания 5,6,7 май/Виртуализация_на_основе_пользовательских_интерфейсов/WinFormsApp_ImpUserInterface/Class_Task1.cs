using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_ImpUserInterface
{
    class Class_Task1 : IEvaluate
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
            int count = str_paramValue.Length;
            string str = String.Format("В числе {0} символов", count);
            return str;
        }
    }
}
