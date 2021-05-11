using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    class UserRegistration
    {
        public string FristName()
        {

            string first_name;
            Console.WriteLine("Enter first name \n  ::first name start with cap and has minimum 3 charecters");
            first_name = Console.ReadLine();

            string exp = "^[A-Z]{1,}..";

            Regex re_firstName = new Regex(exp);

            if (re_firstName.IsMatch(first_name))
            {
                return first_name;
            }
            else
            {
                Console.WriteLine("in valid input ");
                return null;
            }
        }
        public string LastName()
        {
           
            string last_name;
            Console.WriteLine("Enter Last name \n  :: last name start with cap and has minimum 3 charecters");
            last_name = Console.ReadLine();
            
            string exp = "^[A-Z]{1,}..";
            
            Regex re_firstName = new Regex(exp);
            
            if (re_firstName.IsMatch(last_name))
            {
                return last_name;
            }
            else
            {
                Console.WriteLine("in valid input ");
                return null;
            }
        }
    }
}
