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
        public string Email()
        {
            
            string email;
            Console.WriteLine("Enter Last email id \n  :: email E.g :- abc.xyz@bl.com ");
            email = Console.ReadLine();
           
            string exp = "^[a-zA-Z0-9]*@[a-zA-Z0-9]*.[a-zA-Z0-9]{2,4}$";
            
            Regex re_email = new Regex(exp);
            
            if (re_email.IsMatch(email))
            {
                return email;
            }
            else
            {
                Console.WriteLine("invalid input ");
                return null;
            }
        }
        public string PhoneNumber()
        {
            
            string phone_number;
            Console.WriteLine("Enter  phone number \n  :: E.g -- 91 9919819801 - Country code follow by space and 10 digit number ");
            phone_number = Console.ReadLine();
            
            string exp = "^[0-9]{2} [0-9]{10}$";
            
            Regex re_phonenumber = new Regex(exp);
            
            if (re_phonenumber.IsMatch(phone_number))
            {
                return phone_number;
            }
            else
            {
                Console.WriteLine("invalid input ");
                return null;
            }

        }
    }
}
