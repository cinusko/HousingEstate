using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HousingEstate
{
    internal class Flat
    {
        private int flatNum;
        private int area;
        private int rooms;

        public Flat(int flatNum, int area, int rooms)
        {
            this.flatNum = flatNum;
            this.area = area;
            this.rooms = rooms;
        }

        public int FlatNum
        {
            get { return flatNum; }
            set { flatNum = value; }
        }

        public int Area
        {
            get { return area; }
            set { area = value; }
        }

        public int Rooms
        {
            get { return rooms; }
            set { rooms = value; }
        }

        public List<Person> persons = new List<Person>();

        public void AddHabitant(Person Inhabitant)
        {
            persons.Add(Inhabitant);
        }


        public override string ToString()
        {
            return "Flat number: " + this.FlatNum + "\nArea of this flat is " + this.Area + "\nThere are " + this.Rooms + " rooms";   
        }
    }
}
