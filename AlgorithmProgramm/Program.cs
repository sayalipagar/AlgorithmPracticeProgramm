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
                Console.WriteLine("Enter Your Choice : \n");
                Console.WriteLine("1.Binary Search");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearch search = new BinarySearch();
                        search.Search(FILE_PATH);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}