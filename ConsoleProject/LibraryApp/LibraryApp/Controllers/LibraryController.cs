using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Controllers
{
    public class LibraryController
    {
        public void Create()
        {

            ConsoleColor.Red.WriteConsole("add liberary name");
            string liberaryName=Console.ReadLine();

            ConsoleColor.Red.WriteConsole("add library seat count");
            string seatCountStr = Console.ReadLine();
            int seatCount;
            bool isCorrectSeatCount =int.TryParse(seatCountStr, out seatCount);

            if (isCorrectSeatCount)

            {
                Library library = new Library()
                {
                    Name= liberaryName,
                    SeatCount= seatCount
                };
                
            }
            else
            {
                ConsoleColor.Red.WriteConsole("add correct format seat count");
            }
        }
    }
}
