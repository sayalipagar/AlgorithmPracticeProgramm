namespace AlgorithmProgramm
{
    internal class Program
    {
        const string FILE_PATH = @"D:\DotNetPrograms\AlgorithmPracticeProgramm\AlgorithmProgramm\Word.txt";
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter Your Choice :");
                Console.WriteLine("1.Binary Search\n2.BubbleSort\n3.Anagram\n4.PrimeNo\n5.PrimePalindromeAnagram");
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

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}