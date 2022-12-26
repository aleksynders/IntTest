using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntTest
{
    public static class FirstFunction
    {
        public static double getSine(double x) // метод синуса
        {
            double eps = 0.000000000000001, t = x, amount = 0;
            int i = 1;
            do
            {
                amount += t;
                i++;
                t *= -x * x / (2 * i - 1) / (2 * i - 2);
            } while (Math.Abs(t) > eps);
            return amount;
        }
        public static double getCosine(double x) // Функция для подсчета косинуса по ряду Тейлора
        {
            double eps = 0.000000000000001, amount = 0, t = 1;
            int i = 0;
            do
            {
                amount += t; 
                t *= -x * x / ++i / ++i;
            } while (Math.Abs(t) > eps);

            return amount;
        }
    }
}
