using System;

namespace Constructor;
    public class Program
{
        public static void Main(string[] args)
    {
            // Default constructor
            Bebek bebek1 = new Bebek();

            // Ad ve Soyad parametrelerini alan constructor
            Bebek bebek2 = new Bebek("Ali", "Veli");
            bebek2.Info();
    }
}
