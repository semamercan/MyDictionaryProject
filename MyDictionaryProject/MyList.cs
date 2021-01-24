using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryProject
{
    class MyList<T1,T2> //Koleksiyonlar(örn List) arka planda bir array yönetiyor. Bu yüzden array oluşturup eleman sayısını vermemiz gerek. Bunun için de constructor kullanırız.
    {
        T1[] names; //İlk T arrayı oluşturduk. Bu array çalışanların isimlerini içeriyor.
        T2[] business; //İkinci T arrayı çalışanların iş bölümünü içeriyor.
        public MyList() //Class ile aynı ismi olmasından constructor olduğunu anlayabiliriz.
        {
            names = new T1[0]; //constructor yapısında 0 elemanlı bir array oluşturduk.
            business = new T2[0];
        }
        public void Add(T1 employeeName, T2 employeeBusiness) 
        {
            T1[] tempArray1 = names; //New'lediğimiz için önceki datamız uçup gitmesin diye önceki dataları emanet edebileceğimiz tempArray oluşturuyoruz.
            T2[] tempArray2 = business;

            names = new T1[names.Length + 1]; //T1 arrayına bir boş alan ekledik.
            business = new T2[business.Length + 1]; //T2 arrayına bir boş alan ekledik.

            for (int i = 0; i < tempArray1.Length; i++)  
            {
                names[i] = tempArray1[i];
            }
            for (int i = 0; i < tempArray2.Length; i++)
            {
                business[i] = tempArray2[i];
            }
            names[names.Length - 1] = employeeName;
            business[business.Length - 1] = employeeBusiness;
        }
        public T1[] Names
        {
            get { return names; }
        }
        public T2[] Business
        {
            get { return business; }
        }

    }
}
