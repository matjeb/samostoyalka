namespace uzhas
{
    class Program
    {
        static void Main()
        {
            Building[] buildings = new Building[2] { new Building("завод по производству дырок для бубликов", 10000, 100),
                new Building("завод по производству рукавов для жилеток", 9000, 98) };
            for (int i = 0; i < buildings.Length; i++)
            {
                buildings[i].DisplayInfo();
            }

            Settlement settlement = new Settlement(100000);
            settlement.AddBuilding(buildings[0]);
            settlement.AddBuilding(buildings[1]);
            settlement.AddBuilding(new Building("завод по производству облаков", 125000, 70));
            Console.WriteLine(settlement.GetTotalProduction());

            GameManager gameManager = new GameManager(settlement, 100);
            gameManager.Settlement.AddBuilding(new Building("завод по производству облаков", 12500, 50));
            gameManager.Settlement.ShowBuildings();
            gameManager.SimulateProduction();
        }
    }
}