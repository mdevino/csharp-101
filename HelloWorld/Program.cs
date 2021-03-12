 using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Someone";
            bool isWorking = false;

            Console.WriteLine("Hello World!");
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            try
            {
                var numberString = "1234";
                byte b = Convert.ToByte(numberString);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("Type 'byte' cannot store a value larger than 256");
            }

            Console.WriteLine(10 / 3);

            // Single-line comment

            /* Block comment */
        }
    }
}
