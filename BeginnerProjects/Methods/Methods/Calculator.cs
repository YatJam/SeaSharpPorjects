namespace Methods
{
    public class Calculator
    {
        /*By using the params keyword, you can specify a method parameter that takes a variable number of arguments.
        The parameter type must be a single-dimensional array.
        No additional parameters are permitted after the params keyword in a method declaration,
        and only one params keyword is permitted in a method declaration.
        If the declared type of the params parameter is not a single-dimensional array,
        compiler error CS0225 occurs.
        When you call a method with a params parameter, you can pass in:
        A comma-separated list of arguments of the type of the array elements.
        An array of arguments of the specified type.
        No arguments. If you send no arguments, the length of the params list is zero.*/
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}