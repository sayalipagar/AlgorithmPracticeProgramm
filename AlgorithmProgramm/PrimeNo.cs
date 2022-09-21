using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgramm
{
    internal class PrimeNo
    {
        public void Prime()
        {
            int i = 2;
            Console.WriteLine("Print Prime No 0-1000");
            while(i<1000)
            {
                bool count = false;
                for (int j=2;j<i;j++)
                {
                    if(i % j == 0)
                    {
                        count = true;
                        break;
                    }
                }
                if (count == false)
                {
                    Console.WriteLine(i + " ");
                }
                i++;
            }
        }
    }
}
