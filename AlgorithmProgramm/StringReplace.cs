using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProgramm
{
    internal class StringReplace
    {
        public void Validate(string actual,string name)
        {
            string result = actual.Replace("<< name >>", name);
            result.Replace("<< full name >>", name);
            Console.WriteLine(result);
        }
        public void Validate1(string actual, string contactno)
        {
            string result = actual.Replace("<< no >>", contactno);
            result.Replace("<< contact no >>", contactno);
            Console.WriteLine(result);
        }
        public void Validate2(string actual, string Date)
        {
            string result = actual.Replace("<< date >>", Date);
            result.Replace("<< Date date >>", Date);
            Console.WriteLine(result);
        }
    }
}
       
            
        


            
        
