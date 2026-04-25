namespace Task2
{
    public class CalculationManager
    {
        private MathOperations _math = new MathOperations();

        public void PerformCalculation(int x, int y)
        {
            try
            {
                int result = _math.Divide(x, y);
                Console.WriteLine($"Результат: {result}");
            }
            catch (DivideByZeroException ex)
            {
                throw new MathException("Ошибка в модуле вычислений: попытка деления на ноль.", ex);
            }
        }
    }
}