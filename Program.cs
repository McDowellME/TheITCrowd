using System;
using System.Threading;

namespace TheITCrowd
{
    public class Program
    {
        public static Caller[] person = new Caller[4];
        public static void CreateCalls()
        {
            Random rnd2 = new Random();
            string[] name = {
                "Holly",
                "Mary",
                "Bob",
                "Tom",
                "Mindy",
            };
            string[] problem = {
                "1","2","3",
            };

            int callerIndex = rnd2.Next(name.Length);
            int issueIndex = rnd2.Next(problem.Length);


            for (int i = 0; i < person.Length; i++)
            {
                person[i] = new Caller(name[callerIndex], problem[issueIndex]);
            }

        }
        public static void CallIT()
        {
            Console.Write("Do you want to call IT? \t y/n?\t");
            string yesOrNo = Console.ReadLine().ToLower();
            


            if (yesOrNo == "y")
            {
                Random rnd1 = new Random();
                int ringIndex = rnd1.Next(1, 4);
                Console.WriteLine();

                for (int i = 0; i < ringIndex; i++)
                {
                    Console.WriteLine("ring ring...");
                    Thread.Sleep(2000);
                }

                Staff.AnswersPhone();
                Thread.Sleep(2000);
                Caller.CallerAnswers();
                
            }       
            else
            {
                Console.WriteLine("\n Goodbye!");
            }
        }
        static void Main(string[] args)
        {
        CreateCalls();
        CallIT();
        }
    }
}
