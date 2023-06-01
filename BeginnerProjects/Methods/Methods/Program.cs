namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {   
            //calling static methods below
            useParams();
            UsePoints();

           //var number = int.Parse("abc");
            int number;
            //TryParse does not throw an exception, instead throws a boolean
            // it requires an out modifier and have to declare int number separately
            // otherwise can use Parse but would need a try,catch block
           var result = int.TryParse("abc", out number);
           if (result)
            System.Console.WriteLine(number);
            else
                System.Console.WriteLine("conversion failed.");
        }

        static void useParams()
        {
             var calculator = new Calculator();
            //example of params allowing multiple inputs in arguments
            System.Console.WriteLine(calculator.Add(1, 2));
            System.Console.WriteLine(calculator.Add(1, 2, 3));
            System.Console.WriteLine(calculator.Add(1, 2, 3, 4));
            System.Console.WriteLine(calculator.Add(new int[]{1, 2, 3, 4, 5}));
        }

        static void UsePoints()
        {
             try
            {
                var point = new Point(10, 20);
                /*to execute error handling, the object was changed to null
                point.Move(new Point(40, 60));*/
                point.Move(null);
                System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                System.Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("an unexpected error occured");
            }
        }

    }
}