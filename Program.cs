using SimpleCalculator;

struct EReturnValueInput
{
    public float FisrtValue;
    public float SecondValue;
    
    public EReturnValueInput(float fisrtValue, float secondValue) => (FisrtValue, SecondValue) = (fisrtValue, secondValue);
}

namespace SimpleCalculator
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.Clear();
            WelcomeMessage();
            ChosenOperation();
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

        private static void ChosenOperation()
        {
            Console.WriteLine("[0] Sum\n[1] Substract\n[2] Multiply\n[3] Division => ");
            Console.Write("Enter the operation: ");
            var operation = float.Parse(Console.ReadLine());

            switch (operation)
            {
                case 0:
                {
                    Sum();
                    Console.ReadKey();
                    break;
                };
                case 1:
                {
                    Substract();
                    Console.ReadKey();
                    break;
                };
                case 2:
                {
                    Multiply();
                    Console.ReadKey();
                    break;   
                };
                case 3:
                {
                    Division();
                    Console.ReadKey();
                    break;
                };
            }
        }

        private static void PrintResult(float result)
        {
            Console.WriteLine($"The result is: {result}");
        }
        
        private static void Sum()
        {
            var values = GetValues();
            var result = values.FisrtValue + values.SecondValue;
            Console.Clear();
            PrintResult(result);
        }

        private static void Substract()
        {
            var values = GetValues();
            var result = values.FisrtValue - values.SecondValue;
            Console.Clear();
            PrintResult(result);
        }

        private static void Multiply()
        {
            var values = GetValues();
            var result = values.FisrtValue * values.SecondValue;
            Console.Clear();
            PrintResult(result);
        }

        private static void Division()
        {
            var values = GetValues();
            var result = values.FisrtValue / values.SecondValue;
            Console.Clear();
            PrintResult(result);
        }
    }    
}

