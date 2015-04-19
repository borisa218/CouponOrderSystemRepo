using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponOrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (var ctx = new CouponDBContext())
            {
                BusinessOwner bo = new BusinessOwner() { Name = "boris", Age = 26, Email = "sdsd", Password = "1232", Sex = Sex.Male , UserName = "borisal" };
                BusinessOwner bo2 = new BusinessOwner() { Name = "boris", Age = 26, Email = "sdsd", Sex = Sex.Male, UserName = "borisal" };

                ctx.Persons.Add(bo);
                ctx.SaveChanges();
            }

        }
    }
}
