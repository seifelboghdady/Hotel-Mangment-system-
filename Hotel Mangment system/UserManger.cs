using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Mangment_system
{
    internal class UserManger
    {
        private Dictionary<string, string> Users = new Dictionary<string, string>();
        public void signup()
        {
            Console.WriteLine("Enter Your Email/Username :-");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your password :-");
            string password = Console.ReadLine();
            //check username is unique
            if (!(Users.ContainsKey(username))){
                Users.Add(username, password);

                Console.WriteLine("Sign UP Succesfly");
                
            }
            else
            {
                Console.WriteLine("Username already exists!");
            }
        }
        public void Login()
        {
            Console.WriteLine("Enter Your Email/Username :-");
            string username = Console.ReadLine();
            Console.WriteLine("Enter your Password");
            string password = Console.ReadLine();
            //check username is exist
            if (Users.ContainsKey(username))
            {
                //check password is correct
               if( Users[username] == password)
                {
                    Console.WriteLine("you are Log in Correct");
                    Services service = new Services();
                    service.List_login();
                }
                else
                {
                    Console.WriteLine("password or username incorrect");
                }
            }
            else
            {
                Console.WriteLine("this Username not Exist!!!");
            }

        }
    }
}
