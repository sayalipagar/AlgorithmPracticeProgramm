using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgramm
{
    public class BalancedParaenthesis
    {
        public void Balanced(string file)
        {
            string data = File.ReadAllText(file);
            string[] words = data.Split(" ");
            StackGeneric<string> stack = new StackGeneric<string>();
            foreach(var item in words)
            {
                if (item.Contains("("))
                {
                    stack.Push(item);
                }
                if(item.Contains(")"))
                {
                    stack.Pop();
                }
            }
            stack.Peek();
        }
    }
}
