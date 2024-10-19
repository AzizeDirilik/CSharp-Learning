namespace ValueAndReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 100;
            var result = Add(ref number1, number2);
            Console.WriteLine(result);
            Console.WriteLine(number1);
            Console.WriteLine(number2);

            static int Add(ref int num1, int num2)
            {
                num1 = 30;
                return num1 + num2;
            }

        }
    }
}
