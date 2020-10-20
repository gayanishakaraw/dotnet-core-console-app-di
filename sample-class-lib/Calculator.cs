namespace sample_class_lib
{
    public class Calculator : ICalculator
    {
        public double Sum(double numberOne, double numberTwo) 
        => numberOne + numberTwo;
    }
}
