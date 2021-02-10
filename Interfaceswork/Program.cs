using System;

namespace Interfaceswork
{
    class Program
    {

        //interfaceler newlenemezler
        //interfaceler onu implemente eden  classın referrans numarasını tutabilirler
        static void Main(string[] args)
        {

            IPersonManager customerManager = new CustomerManager();
           
            IPersonManager employeManager = new EmployeManger();

            IPersonManager internManager = new InternManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(customerManager);
            projectManager.Add(employeManager);
            projectManager.Add(internManager);

        }
    }



    interface IPersonManager
    {
        void Add();
        void Update();
        void Delete();
    }


    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Musteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Musteri Güncellendi");
        }

        public void Delete()
        {
            Console.WriteLine("Musteri Silindi");
        }
    }

    class EmployeManger : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Musteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Musteri Güncellendi");
        }

        public void Delete()
        {
            Console.WriteLine("Musteri Silindi");
        }

       
    }

    class ProjectManager
    {       //ikisinde de implemente edilen interfacei kullanıyoruz
        public void Add(IPersonManager personManager)
        {
           personManager.Add();
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi");
        }

        public void Delete()
        {
            Console.WriteLine("Stajyer Silindi");
        }
    }




}
