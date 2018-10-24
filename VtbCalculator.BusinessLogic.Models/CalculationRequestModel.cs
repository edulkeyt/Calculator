namespace VtbCalculator.BusinessLogic.Models
{
    public class CalculationRequestModel
    {
        public decimal LeftOperand { get; set; }
        public decimal RightOperand { get; set; }
        public int OperationType { get; set; }
    }
}