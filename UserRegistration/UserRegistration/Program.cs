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
            string email = null;
            string phone_number = null;
            string password = null;

            UserRegistration obj_userregistaration = new UserRegistration();


            while (first_name is null)
                first_name = obj_userregistaration.FristName();

            while (last_name is null)
                last_name = obj_userregistaration.LastName();

            while (email is null)
                email = obj_userregistaration.Email();

            while (phone_number is null)
                phone_number = obj_userregistaration.PhoneNumber();

            while (password is null)
                password = obj_userregistaration.Password();

            Console.WriteLine("First name  : " + first_name);
            Console.WriteLine("Last name  : " + last_name);
            Console.WriteLine("Email  : " + email);
            Console.WriteLine("Phone Number  : " + phone_number);
            Console.WriteLine("Password  : " + password);
        }
    }
}
