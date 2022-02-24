using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTask
{
    internal class FactorTask
    {
        string result;
        int num;

        public FactorTask() 
        {
            Console.Write("Введите число: ");
            if (int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine(Factor(num));
            }
            else 
            {
                throw new Exception("Не число");
            }

        }

        public string Factor(int num) 
        {
            int b = 3;
            int c = (int)Math.Sqrt(num) + 1;

            if(num == 1)
                return "[ОШИБКА] 1 нельзя разделить на множители";

            if (num <= 0)
                return "[ОШИБКА] Число должно быть натуральным!";

            while (num % 2 == 0) 
            {
                num = num / 2;
                result += "2*";
            }

            while (b < c) 
            {
                if ((num % b) == 0)
                {
                    if (num / b * b - num == 0)
                    {
                        result += b.ToString() + "*";
                        num = num / b;
                        c = (int)Math.Sqrt(num) + 1;
                    }
                    else 
                    {
                        b += 2;
                    }
                }
                else 
                {
                    b += 2;
                }
            }
            result += num.ToString();



            return $"[РЕЗУЛЬТАТ] {result}";
        }
    }
}
