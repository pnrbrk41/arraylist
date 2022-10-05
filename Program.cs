using System;
using System.Collections;
using System.Collections.Generic;
namespace arraylist{

    class Program{

        static void Main(string[] args){

            ArrayList liste= new ArrayList();
           // liste.Add("Ayşe");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add("a");

            //içerisindeki verilere erişim
            //Console.WriteLine(liste[1]);

            //foreach( var item in liste)
             // Console.WriteLine(item);

              Console.WriteLine("****** Add Range*********");
              //string[] renkler= {"kırmızı","sarı", "yeşil"};
              List <int> sayilar = new List<int>{1,8,3,7,9,92,5};
              //liste.AddRange(renkler);
              liste.AddRange(sayilar);

              foreach (var item in liste)
              Console.WriteLine(item);

              //sort
              Console.WriteLine("******sort********");
              liste.Sort();

              foreach(var item in liste)
              Console.WriteLine(item);


              //binaryy search
              Console.WriteLine("******Binaryy******");
              Console.WriteLine(liste.BinarySearch(9));

              //Reserve
              Console.WriteLine("*************reserve**********");
              liste.Reverse();

              foreach(var item in liste)
              Console.WriteLine(item);

              liste.Clear();


        }
    }
}