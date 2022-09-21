using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgramm
{
    internal class BinarySearch
    {
        public void Search(string filePath)
        {
            string data = File.ReadAllText(filePath);
            string[] words = data.Split(",");
            Console.WriteLine("****************\n");
            Console.WriteLine("Enter Words To Search.....");
            string search = Console.ReadLine();
            foreach (var item in words)
            {
                if (search.ToLower().Equals(item.ToLower()))
                {
                    Console.WriteLine("Word are Found!!!!!");
                    Console.WriteLine("************************\n");
                    return;
                }
            }
            Console.WriteLine("Word Not Found!!!");

        }
    }
}

