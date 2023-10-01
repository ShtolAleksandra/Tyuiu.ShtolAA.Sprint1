using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.ShtolAA.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {

        public int Calculate(double x)
        {
            string res = x.ToString();
            string[] array = res.Split(',');
            string result = array[1];

            if (result.Length > 0)
            {
                char v = result[0];
                int y = v - '0';
            return y;
            }
            return 0;
        }
    }
}
