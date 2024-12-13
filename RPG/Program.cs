using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    ///<summary>게임의 시작을 다루는 클래스</summary>
    class Program
    {
        static GameManager _gameManager = new GameManager();

        static void Main(string[] args)
        {
            Console.WindowWidth = 85; // 창 너비 설정
            Console.WindowHeight = 40; // 창 높이 설정

            _gameManager.Update();
        }
    }
}