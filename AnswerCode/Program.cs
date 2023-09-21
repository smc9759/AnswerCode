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
            int A = int.Parse(szInput[0]);
            int B = int.Parse(szInput[1]);
            int C = int.Parse(szInput[2]);
            int result_A = (A + B) % C;
            int result_B = ((A % C) + (B % C)) % C;
            int result_C = (A*B)% C;
            int result_D = ((A % C) * (B % C))% C;
            Console.WriteLine(result_A);
            Console.WriteLine(result_B);
            Console.WriteLine(result_C);
            Console.WriteLine(result_D);

            return 0;
        }
    }
}
