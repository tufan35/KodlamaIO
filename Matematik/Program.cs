using System;
using System.Linq;

namespace Matematik
{
    class Program
    {
        static void Main(string[] args)
        {

            DortIslem dortıslem = new DortIslem();
            dortıslem.Topla(5, 6);

            //Console.WriteLine(Add3());
        }

        ////istediğin kadar sayıyı girip çarpabilir yada toplaabilrisn
        //static int Add3(params int[] numbers)
        //{
        //    return numbers.Sum();

        //}

        //static int Add3(int number, params int[] numbers)
        //{
        //    return numbers.Sum();

        //}
    }
}
