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
        // 콘솔 글꼴 설정 함수
        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool SetCurrentConsoleFontEx(
            IntPtr consoleOutput,
            bool maximumWindow,
            ref CONSOLE_FONT_INFO_EX fontInfo);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        private struct CONSOLE_FONT_INFO_EX
        {
            public uint cbSize;
            public uint nFont;
            public short dwFontSizeX;
            public short dwFontSizeY;
            public uint FontFamily;
            public uint FontWeight;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
            public string FaceName;
        }

        public static void SetConsoleFont(string fontName)
        {
            IntPtr hnd = GetStdHandle(-11); // 콘솔 출력 핸들
            var info = new CONSOLE_FONT_INFO_EX();
            info.cbSize = (uint)Marshal.SizeOf(info);
            GetCurrentConsoleFontEx(hnd, false, ref info);
            info.FaceName = fontName;
            SetCurrentConsoleFontEx(hnd, false, ref info);
        }

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool GetCurrentConsoleFontEx(
            IntPtr consoleOutput,
            bool maximumWindow,
            ref CONSOLE_FONT_INFO_EX fontInfo);

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern IntPtr GetStdHandle(int nStdHandle);
    }
}