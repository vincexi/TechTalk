using System;
using static TechTalk.CalculatorService;

namespace TechTalk
{
    public interface ICalculatorService
    {
        decimal Calculate(Operation operation, decimal left, decimal right, DisplayEquation displayEquation, OperationString operationString);
        decimal CalculateV2(
            Func<decimal, decimal, decimal> operation,
            decimal left,
            decimal right,
            Action<decimal, decimal, string, decimal> displayEquation,
            Func<string> operationString);
    }
}