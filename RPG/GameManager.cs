namespace RPG
{
    class GameManager
    {
        Map map = new Map();


        public void Update()
        {
            while (true)
            {
                Console.SetCursorPosition(0, 0);

                for (int i = 0; i < map._map2.GetLength(0); i++)
                {
                    for (int j = 0; j < map._map2.GetLength(1); j++)
                    {
                        Console.Write(map._map2[i, j]);
                    }
                    Console.WriteLine();
                }
                DelayerTime();

                Console.SetCursorPosition(0, 0);
                //Console.Clear();
                for (int i = 0; i < map._map.GetLength(0); i++)
                {
                    for (int j = 0; j < map._map.GetLength(1); j++)
                    {
                        Console.Write(map._map[i, j]);
                    }
                    Console.WriteLine();
                }
                DelayerTime();
            }
        }

        public void DelayerTime()
        {
            Thread.Sleep(2000);
        }

    }
}