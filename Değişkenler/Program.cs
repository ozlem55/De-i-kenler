using System;

namespace Değişkenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //int deger=3;
            //string degişken = null;
            //string Degişken = null;        
            //Console.WriteLine(deger);
            //Console.WriteLine(degişken);
            //Console.WriteLine(Degişken);

            byte b = 5; //1 byte
            sbyte s = 5; //1 byte

            short c = 5; //2byte
            ushort u = 5; //2 byte

            Int16 i16 = 2; // 2 byte
            int i = 2;  //4 byte
            Int32 i32 = 2; //4 byte 
            Int64 i64 = 2; //8 byte

            uint ui = 2; //4 byte
            long l = 4; //8 byte
            ulong ul = 4; //8byte

            float f = 4; //4 byte
            double d = 5; //8 btye
            decimal de = 5; //16 byet

            char ch = '2'; //2 byte
            string st = "özlem"; //sınırsız

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4=4.3;

            //string ifadeler

            string str = string.Empty;
            str = "Özlem yılmaz";
            string ad = "Özlem";
            string soyad = "Yılmaz";
            string tamIsım = ad + " " + soyad;

            //integer tanımlama şekilleri

            int integer1 = 5;
            int integer2 = 2;
            int integer3 = integer1*integer2;

            //boolean

            bool bl = 10 < 2;

            //dönüşümeler

            string str20 = "20";
            int int20 = 20;
            string yenideger = str20 + int20.ToString();
            Console.WriteLine(yenideger);



            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21); //çıktı 40

           int  int22 = int20 + int.Parse(str20); //çıktı 40

            //datetime 

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);



            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);


            string hover = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hover);
        }
    }
}
