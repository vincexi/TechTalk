using System;

namespace TechTalk
{
    public class Alert : IAlert
    {
        public void DisplayEquation(decimal left, decimal right, string operation, decimal answer)
        {
            Console.WriteLine($"{left} {operation} {right} = {answer}");
        }
    }
}
