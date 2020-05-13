using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Exam;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneData db = new PhoneData();

            using (db)
            {
                Phone p1 = new Phone() { Name = "Samsung S 20", Price = 500, OpSystem = "Android", OsImage = "/images/android.png", PhoneImage = "/images/s20.jpg" };
                Phone p2 = new Phone() { Name = "Iphone 11", Price = 600, OpSystem = "IOS", OsImage = "/images/apple.png", PhoneImage = "/images/iphone11.png" };

                db.Phones.Add(p1);
                db.Phones.Add(p2);

                Console.WriteLine("Added phones to database");

                db.SaveChanges();

                Console.WriteLine("Phones saved to the database");
            }
        }
    }
}
