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
            var values = GetValues();
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
    }    
}

