namespace AlgorithmProgramm
{
    public class Program
    {
        const string FILE_PATH = @"D:\DotNetPrograms\AlgorithmPracticeProgramm\AlgorithmProgramm\Word.txt";
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Your Choice :");
                Console.WriteLine("1.Binary Search\n2.BubbleSort\n3.Anagram\n4.PrimeNo\n5.PrimePalindromeAnagram\n6.StringReplace\n7.BalancedParanthesis");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearch search = new BinarySearch();
                        search.Search(FILE_PATH);
                        break;
                    case 2:
                        BubbleSort bubbleSort = new BubbleSort();
                        bubbleSort.Sort(FILE_PATH);
                        break;
                    case 3:
                        Anagram anagram = new Anagram();
                        anagram.checkAnagram("heart", "earth");
                        break;
                    case 4:
                        PrimeNo prime = new PrimeNo();
                        prime.Prime();
                        break;
                    case 5:
                        PrimePalinAndAnagram list = new PrimePalinAndAnagram();
                        list.PrimeNumber();
                        list.Palindrome();
                        list.AnagramCheck();
                        break;
                    case 6:
                        StringReplace replace = new StringReplace();
                        replace.Validate("Hello << name >>,we have your full name as << full name >> in our system.","abc");
                        replace.Validate1("your contact number is << no >>", "91 7020083651");
                        replace.Validate2("Thank you BridgeLabz << date >>", "02/02/2015");
                       break;
                    case 7:
                        BalancedParaenthesis paraenthesis = new BalancedParaenthesis();
                        paraenthesis.Balanced(FILE_PATH);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}