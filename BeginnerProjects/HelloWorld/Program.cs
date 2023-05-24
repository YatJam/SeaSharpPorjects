
namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //converting
            byte b = 1;
            int i = b;
            Console.WriteLine(i);

            //explicit conversion - example of dataloss due to parts of 1000 being lost
            int d = 1000;
            byte c = (byte)d;
            Console.WriteLine(c);

            //how to handle non-compatible types
            var numberString = "1234";
            int j = Convert.ToInt32(numberString);
            Console.WriteLine(j);

            //raising an exception when converting due to data overflowing
           //try catch throw block will prevent application crashing
           try
           {
            var numberStringTwo = "1234";
            byte k = Convert.ToByte(numberStringTwo);
            // byte does not have enough memory to store value and will crash when compiled
            Console.WriteLine(k);
           }
           catch (Exception)
           {
            Console.WriteLine("The number could not be converted to a byte");
            
           }
            
            // declaring a constant, note the f suffix
            const float Pi = 3.14f;

            // example of a format string, combining arguments and values
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);

            // using var so compiler will detect data type based on value
            // can hover over the var and should indicate data type
            var number = 2;
            var count = 10;
            var totalPrice = 20.95f;
            var character = 'A';
            var firstName = "James";
            var isWorking = true;

            /* original variables with specific data types
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "James";
            bool isWorking = true;
            */

            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

        }
    }
}