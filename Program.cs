using System;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Generic List
            // using System.Collections.Generic
            // List<T> -> class
            // T -> Object

            List<int> numberList = new List<int>();

            numberList.Add(42);
            numberList.Add(3);
            numberList.Add(7);
            numberList.Add(32);
            numberList.Add(31);
            numberList.Add(26);
            numberList.Add(46);
            numberList.Add(13);

            List<string> colorList = new List<string>();

            colorList.Add("Kirmizi");
            colorList.Add("Mavi");
            colorList.Add("Sari");
            colorList.Add("Yesil");
            colorList.Add("Mor");
            colorList.Add("Turuncu");

            // Count
            Console.WriteLine(numberList.Count);
            Console.WriteLine(colorList.Count);

            // Liste elemanlarını yazdırma
            foreach (var item in numberList)
            {
                Console.Write(item + " // ");
            }
            Console.WriteLine();
            foreach (var item in colorList)
            {
                Console.Write(item + " // ");
            }

            //Listeden eleman çıkarma
            numberList.Remove(3);
            colorList.Remove("Kirmizi");

            numberList.RemoveAt(4);
            colorList.RemoveAt(3);

            foreach (var item in numberList)
            {
                Console.Write(item + " // ");
            }
            Console.WriteLine();
            foreach (var item in colorList)
            {
                Console.Write(item + " // ");
            }
            Console.WriteLine();

            // Liste içerisinde eleman arama
            if(numberList.Contains(31))
            {
                Console.WriteLine("31 liste içerinde bulundu.");
            }

            //Elemanın indexine erişme
            Console.WriteLine(colorList.BinarySearch("Turuncu"));

            //Diziyi List'e çevirme
            string[] animalArray = {"kedi", "köpek", "kuş", "at"};
            List<string> animalList = new List<string>(animalArray);

            foreach (var item in animalArray)
            {
                Console.Write(item + " // ");
            }
            Console.WriteLine();
            
            foreach (var item in animalList)
            {
                Console.Write(item + " // ");
            }
            Console.WriteLine();

            //Liste içerisinde object tutma.
            List<Users> UserList = new List<Users>();
            
            Users user1 = new Users();
            user1.Isim = "Ugur";
            user1.Soyisim = "Yagmur";
            user1.Yas = 25;

            Users user2 = new Users();
            user2.Isim = "Ali";
            user2.Soyisim = "Veli";
            user2.Yas = 30;

            UserList.Add(user1);
            UserList.Add(user2);

            foreach (var user in UserList)
            {
                Console.WriteLine(user.Isim);
                Console.WriteLine(user.Soyisim);
                Console.WriteLine(user.Yas);
            }
        }
    }

    public class Users
    {
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        
        public string Soyisim { get => soyisim; set => soyisim = value; }
        
        public int Yas { get => yas; set => yas = value; }

        
    }
}