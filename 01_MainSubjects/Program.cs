using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    class Baslangic
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Hello World");


            //Console.WriteLine("===== Yemek Kategorileri =====");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Ara Sıcaklar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine("==============================");

            #endregion

            #region  String Değişkenler

            //Değişken_türü  değişken_adı 

            //string name;
            //name = "İshak Karataş";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Mehmet";
            //customerSurname = "Yıldırım";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "denemeprojesi@gmail.com";
            //district = "Kadıköy";
            //city = "İstanbul";

            //Console.WriteLine("===== Müşteri İletişim Bilgileri =====");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim : " + customerPhone);
            //Console.WriteLine("Email Adresi : " + customerEmail);
            //Console.WriteLine("Adres : " + district + "/" + city);
            //Console.WriteLine("--------------------------------------");


            #endregion

            #region İnt Değişkenler

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;
            Console.WriteLine("======= Restorant Menü Fiyatları =======");
            Console.WriteLine();
            Console.WriteLine("1-Hamburger   :______________ " + hamburgerPrice + " TL");
            Console.WriteLine("2-Kola        :______________  " + cokePrice + " TL");
            Console.WriteLine("3-Su          :______________  " + waterPrice + " TL");
            Console.WriteLine("4-Kızartmalar :______________  " + friesPrice + " TL");
            Console.WriteLine("5-Pizza       :______________ " + pizzaPrice + " TL");
            Console.WriteLine("6-Limonata    :______________  " + lemonadePrice + " TL");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamgurgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamgurgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamgurgerPrice + " TL");
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice + " TL");
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice + " TL");
            Console.WriteLine("Kola Tutarı: " + totalCokePrice + " TL");
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice + " TL");
            Console.WriteLine("Su Tutarı: " + totalWaterPrice + " TL");

            Console.WriteLine();

            int totalPrice = totalCokePrice + totalWaterPrice + totalLemonadePrice + totalHamgurgerPrice + totalPizzaPrice + totalFriesPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + " TL");


            #endregion

            Console.Read();
        }
    }
}
