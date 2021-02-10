using InterfacesDemo;
using System;

namespace InterfacesDemo
{
    class Program

    ///BURADA ÇOKLU İMPLEMENTASYON YAPARAK İNTERFACELERİ BAĞIMSIZ GRUPLARDAN OLUŞTIURDUK ÖRNEK OLARAK ROBOT YEMEK YİYEMEZ
    {
        static void Main(string[] args)
        {
            IWorker[] worker = new IWorker[3]
            {
                new Worker(),
                new Manager(),
                new Robot()
            };

            foreach (var wrks in worker)
            {
                wrks.Work();
            }


            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }

            Console.ReadLine();
        }
    }



    interface IWorker
    {
        void Work();
        

    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Yedi");
        }

        public void Work()
        {
            Console.WriteLine("Çalıştı");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maaş Aldı");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Work()
        {
            Console.WriteLine("Çalıştı");
        }

        public void Eat()
        {
            Console.WriteLine("Yedi");
        }

        public void GetSalary()
        {
            Console.WriteLine("Maaş Aldı");
        }
    }
}

class Robot : IWorker
{
    public void Work()
    {
        Console.WriteLine("Çalıştı");
    }
}



