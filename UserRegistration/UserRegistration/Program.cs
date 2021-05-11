using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration !");

            string first_name = null;
            string last_name = null;
           
            UserRegistration obj_userregistaration = new UserRegistration();


            while (first_name is null)
                first_name = obj_userregistaration.FristName();

            while (last_name is null)
                last_name = obj_userregistaration.LastName();


            Console.WriteLine("First name  : " + first_name);
            Console.WriteLine("Last name  : " + last_name);
        }
    }
}
