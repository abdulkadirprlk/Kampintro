
Customer customer1 = new Customer() { Id = 1, FirstName = "Abdulkadir", LastName = "Parlak", City = "İzmir"};

Customer customer2 = new Customer();
customer2.Id = 2;
customer2.FirstName = "salak";
customer2.LastName = "abdulkadir";
customer2.City = "izmir";


Customer customer3 = new Customer(3, "kemal", "furkan", "van");

Console.WriteLine(customer3.FirstName);
Console.WriteLine(customer1.FirstName);


class Customer
        
{
    //default constructor = parametresi olmayan constructor.
    public Customer()
    {
        
    }
    public Customer(int id, string firstName, string lastName, string city)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        City = city;
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
}



