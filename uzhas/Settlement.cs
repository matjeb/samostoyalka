using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzhas
{
    public class Settlement
    {
        private Building[] buildings = new Building[5];
        private int budget;

        public Building[] Buildings {  get { return buildings; } }
        public int Budget { get { return budget; } }

        public Settlement(int  budget)
        { this.budget = budget; }

        public void AddBuilding(Building building)
        {
            bool isAnyFreeSpace = false;
            for (int i = 0; i < buildings.Length; i++)
            {
                if (buildings[i] == null) { isAnyFreeSpace = true; break; }
            }
            if (isAnyFreeSpace)
            {
                if (budget - building.BuildCost >= 0)
                {
                    for (int i = 0; i < buildings.Length; i++)
                    {
                        if (buildings[i] == null)
                        { budget -= building.BuildCost; buildings[i] = building; break; }
                    }
                }
                else { Console.WriteLine("денег нет, но вы держитесь"); }
            }
            else { Console.WriteLine("нет свободных слотов"); }
        }

        public int GetTotalProduction()
        {
            int sum = 0;
            for (int i = 0; i < buildings.Length; i++)
            {
                if (buildings[i] != null) { sum += buildings[i].Production; }
            }
            return sum;
        }

        public void ShowBuildings()
        {
            for (int i = 0; i < buildings.Length; i++)
            {
                if (buildings[i] != null) buildings[i].DisplayInfo();
            }
        }
    }
}
