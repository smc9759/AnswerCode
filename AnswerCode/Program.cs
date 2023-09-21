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
            string szInput1 = Console.ReadLine();
            string szInput2 = Console.ReadLine();

            int nInput1 = int.Parse(szInput1);

            int nInput2Firstletter = szInput2[0] - '0';
            int nInput2Secondletter = szInput2[1] - '0';
            int nInput2Thirdletter = szInput2[2] - '0';

            int line3, line4, line5 = 0;

            line3 = nInput1 * nInput2Thirdletter;
            line4 = nInput1 * nInput2Secondletter;
            line5 = nInput1 * nInput2Firstletter;

            int result = line3 + line4 * 10 + line5 * 100;

            Console.WriteLine(line3);
            Console.WriteLine(line4);
            Console.WriteLine(line5);
            Console.WriteLine(result);

            return 0;
        }
    }
}
