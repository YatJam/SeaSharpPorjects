 namespace ClassConstructors
 {
    public class Customer
        {
            // only using public declaration for this example
            public int Id;
            public string Name;
            public List<Order> Orders;

            public string FirstName;
            public string LastName;

            //default parameterless constructor to allow freedom
            //to create objects without having to provide parameters
            public Customer()
            {
               Orders = new List<Order>(); 
            }

            // declaring a constructor
            public Customer(int id)
            // : this () references default constructor, passes execution to another constructor
            //note: not best practice to convoluted code
                : this()
            {
                this.Id = id;
            }

            // example of constructor overloading
            public Customer(int id, string name)
            //references previous constructor
                : this(id)
            {
                this.Name = name;
            }
        }
 }