using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponOrderSystem
{
    abstract class Person
    {
        public Person()
        {

        }

        public string nName { get; set; }
        public string Email { get; set; }
        public string PhoneNum { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }

        public Sex Sex { get; set; }
    }


    public enum Sex
    {
        Female,
        Male
    }

    public enum Category
    {
        Sports,
        Food,
        Shoping,
        HelpAndBeauty
    }
}
