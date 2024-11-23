using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class GameManager
    {
        private int mapNumber = 1;
        Map map = new Map();


        public void Update()
        {
            while (true)
            {
                DelayerTime();
                MapRendering();
            }
        }

        public void MapRendering()
        {
            if (mapNumber % 1 == 0)
            {
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map._map1.GetLength(0); i++)
                {
                    for (int j = 0; j < map._map1.GetLength(1); j++)
                    {
                        Console.Write(map._map1[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else if (mapNumber % 2 == 0)
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
            }
            else if (mapNumber % 3 == 0)
            {
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map._map3.GetLength(0); i++)
                {
                    for (int j = 0; j < map._map3.GetLength(1); j++)
                    {
                        Console.Write(map._map3[i, j]);
                    }
                    Console.WriteLine();
                }
            }
            else if (mapNumber % 4 == 0)
            {
                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map._map4.GetLength(0); i++)
                {
                    for (int j = 0; j < map._map4.GetLength(1); j++)
                    {
                        Console.Write(map._map4[i, j]);
                    }
                    Console.WriteLine();
                }
            }

            mapNumber++;
        }

        public void DelayerTime()
        {
            Thread.Sleep(2000);
        }
    }
}