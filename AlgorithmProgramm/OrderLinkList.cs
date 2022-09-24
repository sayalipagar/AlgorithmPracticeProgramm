using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgramm
{
    internal class OrderLinkList
    {
        public void Validate(string file)
        {
            int count = 0;
            string data = File.ReadAllText(file);
            string[] words = data.Split(" ");
            LinkedList<string> list = new LinkedList<string>();
            foreach (var item in words)
            {
                list.Add(item);
            }
            // list.Display();
            Console.WriteLine("Enter Word to serach");
            string search = Console.ReadLine();
            if (count == 0)
            {
                list.Add(search);
            }
            else
            {
                Console.WriteLine(words[count]);
            }
            File.WriteAllText(file, list.ToString());
        }
    }
}
