using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat instan class / object
            Time objTime = new Time();
            // memanggil method pada class tersebut
            objTime.DisplayCurrentTime();
            // bisa diakses karena access modifier public
            objTime.Year = 2010;
            objTime.Month = 5;
            objTime.Date = 1;

            Console.WriteLine("Year : {0}", objTime.Year.ToString());
            Console.WriteLine("Month : {0}", objTime.Month.ToString());
            Console.WriteLine("Date : {0}", objTime.Date);
            Console.WriteLine("Hour : {0}", objTime.Hour);
            Console.WriteLine("Minute : {0}", objTime.Minute);
            Console.WriteLine("Second : {0}", objTime.Second);
            Console.WriteLine();

            // Tugas1
            Time Obj = new Time(2018,4,9,10,10,0);
            CetakHasil(Obj);

            Console.ReadKey();
            
        }
        static void CetakHasil(Time waktu)
        {
            Console.WriteLine("Year   : {0}", waktu.Year.ToString());
            Console.WriteLine("Month  : {0}", waktu.Month.ToString());
            Console.WriteLine("Date   : {0}", waktu.Date.ToString());
            Console.WriteLine("Hour   : {0}", waktu.Hour.ToString());
            Console.WriteLine("Minute : {0}", waktu.Minute.ToString());
            Console.WriteLine("Second : {0}", waktu.Second.ToString());
        }
    }
}
