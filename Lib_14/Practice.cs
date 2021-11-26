using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_14
{
    public class Practice
    {
        public static int Sum(int[] mas)
        {
            int sum = mas[0];
            for (int i = 1; i < mas.Length; i++)
            {
                if (mas[i] < 8)
                    sum += mas[i];
                else sum += 0;
                
            }
            return sum;
        }
    }
}
