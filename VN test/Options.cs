using System.Numerics;
using System;
using Raylib_cs;

namespace VN_test
{
    public class Options
    {

        Vector2 circle1 = new Vector2(200f, 300f);
        public void C()
        {
            Raylib.SetSoundVolume(Music.playSound, 1.0f);
            Raylib.PlaySound(Music.playSound);
            Raylib.DrawRectangle(200, 295, 200, 10, Color.WHITE);

            Vector2 mousePosition = Raylib.GetMousePosition();

            Raylib.ClearBackground(Color.BLACK);

            if (Raylib.CheckCollisionPointCircle(mousePosition, circle1, 20) && Raylib.IsMouseButtonDown(MouseButton.MOUSE_LEFT_BUTTON) && !(mousePosition.X < 200) && !(mousePosition.X > 400))
            {
                circle1.X = mousePosition.X;
            }

            Raylib.DrawCircleV(circle1, 20, Color.BLUE);
            Raylib.DrawCircleV(circle1, 12, Color.WHITE);

        }
    }
}
