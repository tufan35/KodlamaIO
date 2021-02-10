using System;

namespace ReferancesType
{
    class Program
    {
        static void Main(string[] args)
        {
            /// arrays, class, interface referans tiplerdir
            /// 

            //    Person person1 = new Person();
            //    Person person2 = new Person();

            //    person1.FirstName = "Tufan";
            //    person2.FirstName = "Engin";


            //    person2 = person1; ///Burada değer eşitlemesi değil adres eşitlemesi yapmaktadır.  referanslar böyle çalışmaktadır.
            //    person1.FirstName = "Derin";

            //    Customer customer = new Customer();
            //    Employee employee = new Employee();
            //    employee.FirstName = "Memet";

            //    PersonManager personManager = new PersonManager(); //erişilen class üzerinden işlem yapabiliriz
            //    personManager.Add(employee);

            //Demo2 
            //var customerManager = Demo2();
            //customerManager.Add(new OracleServerCustomer());

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleServerCustomerDal(),
                new MySqlServerCustomerDal(),
            };


            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadLine();



        }

        private static CustomerManager Demo2()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            return customerManager;
        }


        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string Lastname { get; set; }


        }

        class Customer : Person //Burada İnheritance yapıyoruz

        {
            public string CreditCardNumber { get; set; }
        }
        class Employee : Person
        {
            public int EmployeeNumber { get; set; }
        }


        class PersonManager 
        {
        public void Add(Person person) //Person class'ına erişerel içindeki tiplere erişiyrouz
            {
                Console.WriteLine(person.FirstName);
            }
 
        }
    }
}
