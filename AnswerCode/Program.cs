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
            string[] szInput1 = Console.ReadLine().Split();
            long A = long.Parse(szInput1[0]);
            long B = long.Parse(szInput1[1]);
            long C = long.Parse(szInput1[2]);
            Console.WriteLine(A+B+C);
            
            return 0;
        }
    }
}
