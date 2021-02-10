using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        //Array tutuyoruz
        T[] items;
        
        //consturctor
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items; ///referans numarası kaybolmaması için yeni eleman eklediğimizde bu yüzden yaptık
            items = new T[items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];

            }

            items[items.Length - 1] = item;
        }


    }
}
