using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTask.Tasks
{
    internal class Message
    {
        public string GetResult(int code, string message)
        {
            switch (code)
            {
                case 0:
                    return "[РЕЗУЛЬТАТ] " + message;

                case -1:
                    return "[ОШИБКА] " + message;


                default:
                    return "[ВЫПОЛНЕНО] " + message;

            }
        }
    }
}
