using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 10, City = "Balıkesir", LastName = "Tarlacı", FirstName = "Taner Tolga" };
            Customer customer2 = new Customer(11,"Yusuf","kara", "İstanbul");

        }

        static void çalıştır() 
        { 

        }
    }
    class Customer
    {
        public Customer()// default constructor = parametresi olmayan constuctor
        {

        }
        
        public Customer(int id, string firstname, string lastname, string city)
        {
            Console.WriteLine("yapıcı blok çalıştı");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string City { get; set; }
        public string LastName { get; set; }
    }
}
