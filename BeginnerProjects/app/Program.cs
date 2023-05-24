namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I am the computer, who is dis?");
            string userName = Console.ReadLine();
            Console.WriteLine($"So {userName}, you have invaded my domain");
            Console.WriteLine("Tell me, how many cups of tea have you drank today?");
            int teasDrunk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You have drank {teasDrunk} cups of tea today.");
            Console.WriteLine("I (a mac) do not drink tea, only energy!");
            Console.WriteLine("Where do you come from?");
            string userLocation = Console.ReadLine();
            Console.WriteLine($"I have never heard of {userLocation}...");
            Console.WriteLine("...insignificant.");

        }
    }
}