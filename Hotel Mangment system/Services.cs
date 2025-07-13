using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Mangment_system
{
    internal class Services
    {
        public void List_login()
        {
            Console.Clear();
            Console.WriteLine("Welcome To Our Services\n1] Room Management\n2] Customer Management\n3] Make Reservation\n4] Booking\n5] Payment\n6] Reporting");
            int choose = int.Parse(Console.ReadLine());

        }
        private void choose(int choose)
        {
            if (choose == 1)
            {
                //call Room Mangment
            }
            else if(choose == 2)
            {
                //call Customer mangment
            }
            else if (choose == 3)
            {
                //call booking
            }
            else if (choose == 4)
            {
                //call payment
            }
            else if (choose == 5)
            {
                //call Reporting
            }
        }
        
    }
}
