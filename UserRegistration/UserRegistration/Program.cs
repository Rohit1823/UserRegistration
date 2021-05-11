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
            string first_name;
            Console.WriteLine("Welcome To User Registration !");

            UserRegistration obj_userregistaration = new UserRegistration();


            first_name = obj_userregistaration.FristName();
            if (first_name is null)
                first_name = obj_userregistaration.FristName();


            Console.WriteLine("first name  : " + first_name);
        }
    }
}
