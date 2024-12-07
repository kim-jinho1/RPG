using System;
using System.Threading;

namespace RPG
{
    class GameManager
    {
        private int mapNumber = 1;
        private Map map = new Map();

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
            Console.SetCursorPosition(0, 0);

            // 모든 맵을 배열로 관리
            string[][,] maps = { map._map1, map._map2, map._map3, map._map4 };

            // mapNumber에 따른 현재 맵 선택 (0부터 시작하는 인덱스 기반)
            string[,] currentMap = maps[(mapNumber - 1) % maps.Length];

            for (int i = 0; i < currentMap.GetLength(0); i++)
            {
                for (int j = 0; j < currentMap.GetLength(1); j++)
                {
                    Console.Write(currentMap[i, j]);
                }
                Console.WriteLine();
            }   

            mapNumber++;
        }

        public void DelayerTime()
        {
            Thread.Sleep(2000);
        }
    }
}