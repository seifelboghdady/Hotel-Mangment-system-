using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Mangment_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UserManger user = new UserManger();
            while (true) 
            {
                Console.WriteLine("Hello to your Hotel\n1] Sign up\n2] Log in\n3] About Services\n<<please inter only one number>>");
                int Choose = int.Parse(Console.ReadLine());
                Console.Clear();
                choose(Choose, user);
                Console.Clear();

            }


        }
        public static void choose(int choose, UserManger user)
        {
            //UserManger user = new UserManger();
            if (choose == 1){
                user.signup();
                Console.ReadKey();
            }
            else if (choose == 2){
                user.Login();
                Console.ReadKey();
            }
            else if (choose == 3){
                Console.WriteLine("Our main services include user registration, secure login,\nand access to a variety of specialized features tailored to meet users' needs.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("invalid input");
                Console.ReadKey();
            }
        }
    }
}
