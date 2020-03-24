using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieTipAgenda
{
    class Program
    {
        static void Main(string[] args)
        {
            PersoaneContact persoana = new PersoaneContact("Emanuel", "0743307248", "emy_baciu@yahoo.com");

            
            Console.WriteLine(persoana.Info());

            Console.ReadKey();

        }
    }
}
