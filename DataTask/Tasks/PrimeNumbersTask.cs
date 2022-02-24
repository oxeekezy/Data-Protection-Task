using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTask.Tasks
{
    internal class PrimeNumbersTask
    {
        protected int num;

        public PrimeNumbersTask() 
        { }
        public PrimeNumbersTask(string input) 
        {
            if (int.TryParse(input, out int num))
            {
                if (num <= 0)
                    throw new Exception("Число не натуральное!");
                else
                    this.num = num;
            }
            else
                throw new Exception("Не число!");
        }

        public bool IsPrime() 
        {
            bool result = true;
            
            for (var i = 2; i < this.num; i++)
            {
                if (this.num % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        public bool IsPrime(int n)
        {
            bool result = true;

            if (n > 1) 
            {
                for (var i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }
            else 
                result = false;
            
            return result;
        }

        public string PrimesInInterval(string start_, string end_) 
        {
            string result = string.Empty;

            if (int.TryParse(start_, out int start) && int.TryParse(end_, out int end))
            {
                for (int i = start; i <= end; i++)
                    if (IsPrime(i))
                        result += i + "\n";
            }
            else 
                throw new Exception("Проверьте числа на натуральность!");
            
                
            return result;
        }

        public void PrimesInInterval(string start_, string end_, bool write) 
        {
            string result = $"Простые числа в интервале от {start_} до {end_}:\n";
            string path = $"C:/Users/{Environment.UserName}/Desktop/PrimeNumbers.txt";
            if (write)
            {
                string preResult = PrimesInInterval(start_, end_)+"\n";
                File.AppendAllText(path, result+preResult);
                Console.WriteLine($"Файл записан!\nПуть к файлу: {path}");
            }
            else
                Console.WriteLine("Отказано в доступе!");
        }

        public string TwinsInInterval(string start_, string end_) 
        {
            string result = string.Empty;


            if (int.TryParse(start_, out int start) && int.TryParse(end_, out int end)) 
            {
                List<int> primes = new List<int>();
                
                for(int i=start; i<=end; i++)
                    if(IsPrime(i))
                        primes.Add(i);

                for (int i = 0; i < primes.Count; i++)
                    for (int j = i + 1; j < primes.Count; j++)
                        if (Math.Abs(primes[i] - primes[j]) == 2)
                            result += $"({primes[i]},{primes[j]})\n"; 
            }
            else
                throw new Exception("Проверьте числа на натуральность!");

            return result;
        }

        public List<int> EratosthenesSieve(int n) 
        {
            List<int> sieve = new List<int>();

            for (int i = 2; i < n; i++)
                sieve.Add(i);

            for (int i = 0; i < sieve.Count; i++)
                for (int j = 2; j < n; j++)
                    sieve.Remove(sieve[i] * j);
            
            return sieve;
        }
    }



}
