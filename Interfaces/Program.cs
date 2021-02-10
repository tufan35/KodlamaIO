using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();

            personManager.Add(new Customer { FirstName = "Tufan", Lastname = "Cevik", Address = "İzmir", Id = 1 });

            IPerson customer = new Customer();
            personManager.Add(customer);
            Console.ReadLine();
        }

        //İnterfacein amacı temel nesne oluşturup bütün nesneleri oda implemente etmektir.
    }

    interface IPerson //Soyut Nesne
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }

    }
    class Customer : IPerson  //Somut Nesne
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        public string Address { get; set; }

    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }

        public string Department { get; set; }
    }

    class PersonManager //İş katmanlarında kullanılır
    {
        public void Add(IPerson customer)
        {
            Console.WriteLine(customer.FirstName);
        }

       
    }
}
