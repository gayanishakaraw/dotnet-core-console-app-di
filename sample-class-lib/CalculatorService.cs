namespace sample_class_lib
{
    public class CalculatorService : ICalculatorService
    {
        private readonly ICalculator _calculator;
        public CalculatorService(ICalculator calculator)
        {
            _calculator = calculator;
        }

        public double GetSum(double numberOne, double numberTwo) 
        => _calculator.Sum(numberOne, numberTwo);
    }
}