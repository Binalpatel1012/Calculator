namespace CalculatorLibrary
{
    public class Calculator
    {
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal Subtract(decimal a, decimal b)
        {
            return a - b;
        }

        public decimal Multiply(decimal a, decimal b)
        {
            return a * b;
        }

        public decimal Divide(decimal a, decimal b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed!");
            }

            if (a > b)
            {
                throw new ArgumentException("For division, the first parameter must not be greater than the second parameter.");
            }

            return a / b;
        }

        public decimal Modulo(decimal a, decimal b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Modulo by zero is not allowed!");
            }

            if (a > b)
            {
                throw new ArgumentException("For modulo, the first parameter must not be greater than the second parameter.");
            }

            return a % b;
        }
    }
}
