namespace VtbCalculator.Domain.Models
{
    public class CalculationRequest
    {
        public long Id { get; set; }
        public OperationType OperationType { get; set; }
        public decimal OperandLeft { get; set; }
        public decimal OperandRight { get; set; }
    }
}