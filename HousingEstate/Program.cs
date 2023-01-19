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
            Person peter = new Person("Peter", "Zelina", 43);
            Person miro = new Person("Miroslav", "Drigel", 44);
            Person janko = new Person("Jano", "Kanak", 56);

            Flat bytík = new Flat(10, 12, 6);

            bytík.AddHabitant(peter);
            bytík.AddHabitant(janko);
            bytík.AddHabitant(miro);

            //Console.WriteLine(peter.ToString());

            Console.WriteLine(bytík.ToString());

            foreach (var persons in bytík.persons)
            {
                Console.WriteLine(persons.ToString());
            }
            

        }
    }
}
