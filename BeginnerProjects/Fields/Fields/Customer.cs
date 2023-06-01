namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        //readonly can only be declared in the instance field or constructor
        //readonly creates safety in application, means you only have one list and
        //prevents any data loss if list is accidentally reinitialized through a method for example.
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            
        }
    }
}