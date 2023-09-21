using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerCode
{
    class Program
    {
        static int Main(string[] args)
        {
            string[] szInput = Console.ReadLine().Split();

            Console.WriteLine(double.Parse(szInput[0]) / double.Parse(szInput[1]));

            return 0;
        }
    }
}
