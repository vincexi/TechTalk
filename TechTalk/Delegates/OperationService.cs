namespace TechTalk
{
    public class OperationService : IOperationService
    {
        public string AddString()
        {
            return "+";
        }

        public string SubtractString()
        {
            return "-";
        }

        public decimal Add(decimal left, decimal right)
        {
            return left + right;
        }

        public decimal Subtract(decimal left, decimal right)
        {
            return left - right;
        }
    }
}
