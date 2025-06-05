using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_ImpUserInterface
{
    class Class_Task3 : IEvaluate
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
            double result = 1;
            int f = 1;
            for (int i = 1; i <= ParamValue; i++)
            {
                f *= i;
                result -= 1.0 / f;
            }
            string str = String.Format("Сумма ряда: " + result.ToString(), 2);
            return str;
        }
    }
}
