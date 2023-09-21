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
            string szInput1 =  Console.ReadLine();
            string szInput2 =  Console.ReadLine();
            int nInput1 = int.Parse(szInput1);

            int nInput2 = int.Parse(szInput2);
            int nResult = nInput1 + nInput2;
            Console.WriteLine("{0}", nResult);


            return 0;
        }
    }
}
