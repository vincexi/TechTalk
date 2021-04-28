using System;

namespace TechTalk
{
    public class CalculatorService : ICalculatorService
    {
        public delegate decimal Operation(decimal left, decimal right);
        public delegate string OperationString();
        public delegate void DisplayEquation(decimal left, decimal right, string operation, decimal answer);

        public decimal Calculate(Operation operation, decimal left, decimal right, DisplayEquation displayEquation, OperationString operationString)
        {
            var answer = operation(left, right);

            displayEquation(left, right, operationString(), answer);

            return answer;
        }

        public decimal CalculateV2(
            Func<decimal, decimal, decimal> operation,
            decimal left,
            decimal right,
            Action<decimal, decimal, string, decimal> displayEquation,
            Func<string> operationString
            )
        {
            var answer = operation(left, right);

            displayEquation(left, right, operationString(), answer);

            return answer;
        }
    }
}
