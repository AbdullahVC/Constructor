using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Bebek
    {
        private string _name;
        private string _surname;
        private DateTime _birthDay;

        // Parametre almayan default constructor
        public Bebek()
        {
            Console.WriteLine("Ingaaaa"); // Konsola Ingaaaa yazısı yazılır
        }

        // Ad ve Soyad parametrelerini alan constructor
        public Bebek(string ad, string soyad)
        {
            _name = ad;
            _surname = soyad;
            _birthDay = DateTime.Now; // Doğum tarihi şu anki zaman olarak atanır
            Console.WriteLine("Ingaaaa");
        }

        // Bebek bilgilerini ekrana yazdıran metod
        public void Info()
        {
            Console.WriteLine($"Ad: {_name}, Soyad: {_surname}, Doğum Tarihi: {_birthDay}");
        }

        // Bebek sınıfının özellikleri
        public DateTime DogumTarihi
        {
            get 
            { 
                return _birthDay; 
            }
            set
            {
                _birthDay = value; 
            }
        }

        public string Ad
        {
            get 
            { 
                return _name; 
            }
            private set { 
                _name = value; 
            }
        }

        public string Soyad
        {
            get 
            { 
                return _surname; 
            }
            private set 
            {
                _surname = value; 
            }
        }
    }
}
