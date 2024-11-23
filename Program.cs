using SimpleCalculator;

struct EReturnValueInput
{
    public float FisrtValue;
    public float SecondValue;
    
    public EReturnValueInput(float fisrtValue, float secondValue) => (FisrtValue, SecondValue) = (fisrtValue, secondValue);
}

enum EArithmeticOperations
{
    Sum = 0,
    Substract = 1,
    Multiply = 2,
    Divide = 3,
}

namespace SimpleCalculator
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.Clear();
            WelcomeMessage();
            var values = GetValues();
            var operation = ChosenOperation();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("***** Fun with Calculator *****");
        }

        private static EReturnValueInput GetValues()
        {
            Console.Write("Enter the first number: ");
            var firstValue = float.Parse(Console.ReadLine()) ;
            
            Console.Write("Enter the second number: ");
            var secondValue = float.Parse(Console.ReadLine());
            
            return new EReturnValueInput(firstValue, secondValue);
        }

        private static EArithmeticOperations ChosenOperation()
        {
            Console.WriteLine("Enter the operation: ");
            Console.WriteLine("0 - Sum");
            Console.WriteLine("1 - Substract");
            Console.WriteLine("2 - Multiply");
            Console.WriteLine("3 - Divide");
            var operation = float.Parse(Console.ReadLine());

            switch (operation)
            {
                case 0:
                    return EArithmeticOperations.Sum;
                case 1:
                    return EArithmeticOperations.Substract;
                case 2: 
                    return EArithmeticOperations.Multiply;
                case 3: 
                    return EArithmeticOperations.Divide;
                default: 
                    return EArithmeticOperations.Sum;
            }
        }
    }    
}

