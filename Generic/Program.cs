using System;
using System.Collections.Generic;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            sehirler.Add("ankara");
            Console.WriteLine(sehirler.Count);  //bu bir propertyditr
     

            Mylist<string> sehirler2 = new Mylist<string>();
            sehirler2.Add("ankara");
            sehirler2.Add("ankara");
            sehirler2.Add("ankara");
            sehirler2.Add("ankara");
            sehirler2.Add("ankara");
            Console.WriteLine(sehirler2.Count);
        



        }



        class Mylist<T> //generic class
        {
             T[] _array;
            T[] _temparray;
             public Mylist()
             {
                _array = new T[0];
             }
            public void Add(T item)
            {
                _temparray = _array;
                _array = new T[_array.Length + 1];
                for (int i = 0; i < _temparray.Length; i++)
                {
                    _array[i] = _temparray[i];
                }

                _array[_array.Length - 1] = item;
            }

 

            public int Count
            {
                get { return _array.Length; }
               
            }



        }

    }
}
