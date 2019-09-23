using System;
using System.Collections.Generic;
using System.Text;

namespace TheITCrowd
{

    public class Caller
    {
        public static Caller[] Calls = new Caller[4];
        string callerName;
        string itIssue;

        public Caller(string name, string problem)
        {
            this.callerName = name;
            this.itIssue = problem;
        }
        public static void CallerAnswers()
        {
            Console.WriteLine($"\nYou: Hello, this is {Program.person[0].callerName} and my problem is ");
        }
        
    }
}
