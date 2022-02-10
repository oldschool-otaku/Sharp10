using System;

namespace Sharp10
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("выберите задание для проверки");
            
            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    string secondInput = Console.ReadLine();
                    Console.WriteLine(Tasks.GetChar(2, "faggot"));
                    Console.WriteLine(Tasks.GetChar(input, secondInput));
                    Console.WriteLine(Tasks.GetChar(0, "HOHOL"));
                    break;
                }
                case 2:
                    Console.WriteLine(Tasks.CheckLetters("maggot", "tiger"));
                    break;
                
                case 3:
                    Console.WriteLine(Tasks.MakeSomeMagic("MEGAPRIKOL", 1));
                    Console.WriteLine(Tasks.MakeSomeMagic("MEGAPRIKOL", 2));
                    break;
                
                case 7:
                    Console.WriteLine(Tasks.DoSomething("вирус", 1));
                    break;
                
                case 8:
                    Console.WriteLine(Tasks.DoSomething("курсор", 2));
                    break;
                
                case 9:
                    Console.WriteLine(Tasks.DoSomething("пробел", 3));
                    break;
                
                case 10:
                    Console.WriteLine(Tasks.DoSomething("строка", 4));
                    break;
            }
        }
    }
}