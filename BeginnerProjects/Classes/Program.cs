namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            System.Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //static method
            var person = Person.Parse("James");
            person.Introduce("Ewa");

            /* example before parse and static use
            var person = new Person();
            person.Name = "James";
            person.Introduce("Ewa");
            */
        }
    }
}