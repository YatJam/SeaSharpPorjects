namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //arithmatic operators
            var a = 1;
            var b = 2;
            var c = 3;

            // if you wish a floating point number result, will need to cast as float
            Console.WriteLine((float)a / (float)b);

            //comparison operators
            Console.WriteLine(a > b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            //using two negatives will always equal a positive and bad writting
            Console.WriteLine(!(a != b));
            
            //logical operators
            // && equals and
            Console.WriteLine(c > b && c > a);
            //example of a true and false that results false
            Console.WriteLine(c > b && c == a);
            // example of or operator
            Console.WriteLine(c > b || c == a);
            Console.WriteLine(!(c > b || c == a));
        }
    }
}