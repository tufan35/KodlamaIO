using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {


         //   Customer customer = new Customer(); //yeni bir örnek oluşturma metodu
            Customer customer1 = new Customer { Id = 1, FirstName = "Tufan", Lastname = "Cevik", City = "Edirne" };
            //Üstteki yöntem ile alltaki yöntem birbirlerine eşittir hangisini kullanmak istersen
            Customer customer3 = new Customer();
            customer3.Id = 5;
            customer3.FirstName = "Rabia";
            customer3.Lastname = "Cevik";
            customer3.City = "Adana";
            
            
            Customer customer2 = new Customer(2,"dERİN", "Demir", "Keşan ");
        }


        class Customer
        {
            public Customer()
            {

            }
            //default constructor denir. Bu bir yapıcı bloktur.." ()" varsza bir metot vardır
            public Customer( int id, string firstname, string lastname, string city)
            {
                Id = id;
                FirstName = firstname;
                Lastname = Lastname;
                City = city; 
            }

            public int Id { get; set; }
            public string FirstName { get; set; }
            public string Lastname { get; set; }
            public string City { get; set; }

        }
    }
}
