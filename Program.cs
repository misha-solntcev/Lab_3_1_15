using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  15. Начальный вклад в банке равен 1000 руб. Через каждый месяц 
    размер вклада увеличивается на P процентов от имеющейся суммы 
    (P — вещественное число, 0 < P < 25). По данному P определить, 
    через сколько месяцев размер вклада превысит 1100 руб., 
    и вывести найденное количество месяцев K (целое число) и итоговый 
    размер вклада S (вещественное число). */

namespace Lab_3_1_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vklad = 1000;
            double P = 1;
            int month = 0;
            while (vklad < 1100)
            {
                month++;
                vklad = vklad * (1 + P / 100);
                Console.WriteLine($"month = {month}, vklad = {vklad}");
            }
            Console.ReadKey();
        }
    }
}
