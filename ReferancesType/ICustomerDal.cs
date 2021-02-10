using System;
using System.Collections.Generic;
using System.Text;

namespace ReferancesType
{
 public   interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("sql Add");
        }

        public void Delete()
        {
            Console.WriteLine("Delete");
        }

        public void Update()
        {
            Console.WriteLine("Update");
        }
    }
        class OracleServerCustomerDal : ICustomerDal
        {
            public void Add()
            {
                Console.WriteLine(" oracle Add");
            }

            public void Delete()
            {
                Console.WriteLine("Delete");
            }

            public void Update()
            {
                Console.WriteLine("Update");
            }
        }

        class MySqlServerCustomerDal : ICustomerDal
        {
            public void Add()
            {
                Console.WriteLine(" mysql Add");
            }

            public void Delete()
            {
                Console.WriteLine("Delete");
            }

            public void Update()
            {
                Console.WriteLine("Update");
            }
        }

    class CustomerManager
        {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
        }

    
}
