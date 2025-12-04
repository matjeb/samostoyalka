using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uzhas
{
    public class GameManager
    {
        private Settlement settlement;
        private int gameTime;

        public Settlement Settlement {  get { return settlement; } }
        public int GameTime { get { return  gameTime; } }

        public GameManager(Settlement settlement, int gameTime)
        {
            this.settlement = settlement;
            this.gameTime = gameTime;
        }

        public void SimulateProduction()
        {
            int resources = 0;
            for (int t = gameTime; t > 0; t--)
            {
                for (int i = 0; i < settlement.Buildings.Length; i++)
                {
                    if (settlement.Buildings[i] != null)
                    resources += settlement.Buildings[i].Production;
                }
            }
            Console.WriteLine(resources);
        }
    }
}
