using System;

namespace Inheritance
{
    class Program
    {
        //bir classa birden fazla class atanamaz ama interface atanabilir.
        static void Main(string[] args)
        {

            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName =  "Tufan"
                }, 
                new Person
                {
                    FirstName = "Salih"
                },
                new Student
                {
                    FirstName = "Engin"
                }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

        }




        class Person
        {

            public int Id { get; set; }
            public string FirstName { get; set; }
            public String Lastname { get; set; }

            
        }

        class Customer: Person
        {
            public string City { get; set; }

        }

        class Student : Person
        {
            public string Department { get; set; }
        }


    }
}
