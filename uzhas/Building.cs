using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzhas
{
    public class Building
    {
        private string name;
        private int buildCost;
        private int production;

        public string Name { get { return name; } }
        public int BuildCost { get { return buildCost; } }
        public int Production { get { return production; } }

        public Building(string name, int buildCost, int production)
        {
            this.name = name;
            this.buildCost = buildCost;
            this.production = production;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"название: {name}, стоимость: {buildCost}, производство: {production}");
        }
    }
}
