using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Exam
{
    public class Phone
    {
        [Key]
        public string Name { get; set; }
        public double Price { get; set; }
        public string OpSystem{ get; set; }
        public string OsImage{ get; set; }
        public string PhoneImage{ get; set; }

        public void IncreasePrice()
        {
            double AddedPrice = 0.1;

            Price = (Price * AddedPrice) + Price;
            
        }
    }

    public class PhoneData : DbContext
    {

        public PhoneData() : base("ThePhoneData2") { }

        public DbSet<Phone>Phones { get; set; }
    }
}

    

