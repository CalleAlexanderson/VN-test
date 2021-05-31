using System;
using System.Threading;
using Raylib_cs;

namespace VN_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string screen = "options";
            Raylib.SetTargetFPS(60);
            Raylib.InitWindow(1000, 600, "game");
            Options options = new Options();

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                if (screen == "options")
                {
                    options.C();
                }
                Raylib.EndDrawing();
            }
        }
    }
}
