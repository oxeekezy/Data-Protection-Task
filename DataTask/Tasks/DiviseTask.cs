using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTask
{
    internal class DiviseTask
    {
        public int GetNum(string substr) 
        {
            Console.Write($"Введите {substr}: ");
            string num = Console.ReadLine();

            int res = 0;

            if (int.TryParse(num, out res)) 
                return res;
            else
                throw new Exception("Не число");
            
        }
        public string Dividing(int firstNum, int secondNum) 
        {
            if (firstNum > 0 && secondNum > 0)
                if (firstNum % secondNum == 0)
                    return String.Format("[УСПЕШНО] {0} ДЕЛИТСЯ на {1} без остатка\n", firstNum, secondNum);
                else
                    return String.Format("[БЕЗУСПЕШНО] {0} НЕ ДЕЛИТСЯ на {1} без остатка!\n", firstNum, secondNum);
            else
                return "[ОШИБКА] Оба числа должны быть натуральны!\n";

        }
    }
}
