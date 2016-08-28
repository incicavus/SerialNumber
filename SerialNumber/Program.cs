using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialNumber
{


    class Game
    {
        private string serialNumber;

        //propertyler amaca yönelik olarak get veya set bloklarından sadece birine de sahip olabilir. eğer üzerinde çalışılan alanın değeri property ile değiştirilmek istenmiyorsa set bloğu iptal edilir. eğer bu bilgi return edilmek istenmiyorsa get bloğu iptal edilebilir.

        public string SerialNumber
        {
            get { return serialNumber; }
            //set { serialNumber = value; }
        }


        Random gen = new Random();

        public Game()
        {
            serialNumber = "WA";
            for (int i = 0; i < 8; i++)
            {
                serialNumber += gen.Next(10);
            }
        }

        public void CheckSerial(string key)
        {
            //hangi oyun nesnesi bu metodu çağırıyorsa serialNumber alanı o nesneye ait.
            if (serialNumber == key)
                Console.WriteLine("Congrats. You have unlocked the app!..");

            else
            {
                Console.WriteLine("Invalid serial number!..");
                System.Threading.Thread.Sleep(2000);

                Environment.Exit(0);
            }
        }


    }



    class Program
    {
        static void Main(string[] args)
        {
            //int[] d = { 1, 2, 3 };//örneğimizle alakası yok sadece konu anlatılırken örnek verildi
            //Console.WriteLine(d.Length);
            //d.Length = 5;

            Game oyun = new Game();
            Console.WriteLine("Serial:" + oyun.SerialNumber);
            //oyun.SerialNumber = "EA32346461";


            //bir tane metot girilen seri numarasını oyuna ait anahtar ile karşılaştırsın doğrulandığında bir bildirim, hata durumunda ayrı bir bildirim yapılsın.

            Console.Write("Enter your key:");
            oyun.CheckSerial(Console.ReadLine());
            //CheckSerial(Console.ReadLine(), oyun);

            Console.ReadLine();
        }

        //metot-func sadece değer türü değil, aynı zamanda sınıf nesnelerinide parametre olarak kullanabilir.

        //static void CheckSerial(string key, Game g)
        //{
        //    if (key == g.SerialNumber)
        //    {
        //        Console.WriteLine("Congrats. You have unlocked the app!..");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid serial number!..");
        //        System.Threading.Thread.Sleep(2000);

        //        Environment.Exit(0);
        //    }
        //}


    }
}
