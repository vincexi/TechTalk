using System;
using System.Collections.Generic;

namespace TechTalk.Delegates
{
    public class DelegateExample
    {
        public void Run()
        {
            var operation = new OperationService();
            var alert = new Alert();
            var calc = new CalculatorService();

            calc.Calculate(operation.Add, 3, 5, alert.DisplayEquation, operation.AddString);
            calc.Calculate(operation.Subtract, 3, 5, alert.DisplayEquation, operation.SubtractString);

            calc.CalculateV2(operation.Add, 3, 5, alert.DisplayEquation, operation.AddString);
            calc.CalculateV2(operation.Subtract, 3, 5, alert.DisplayEquation, operation.SubtractString);

            calc.CalculateV2(
                (left, right) => left+right,
                3,
                5,
                (left, right, operation, answer) => Console.WriteLine($"{left} {operation} {right} = {answer}"),
                () => "+");

            List<object> obj = new List<object>();
        }
    }
}
