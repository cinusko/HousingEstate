using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Ľudovít", "Štúr", 75);

            Flat flat1 = new Flat(10, 12, 6);

            Console.WriteLine(person1.ToString());

            Console.WriteLine(flat1.ToString());

        }
    }
}
