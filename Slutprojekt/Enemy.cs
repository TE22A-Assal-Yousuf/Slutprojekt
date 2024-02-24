using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class Enemy
{
    public static Rectangle enemyRect = new Rectangle(250, 250, 128, 128);
    Vector2 mousePos = Raylib.GetMousePosition();

    public double enemyHP = 10;
    public double enemyHPMax = 10;

    public void Draw()
    {

        Raylib.DrawRectangleRec(enemyRect, Color.DarkBlue);
        Raylib.DrawText($"Health{enemyHP}", 250, 230, 10, Color.Black);

    }
    public void Damage(){

    Player.points += Player.autoDamage;


     if (Raylib.CheckCollisionPointRec(mousePos, enemyRect))
        {

            if (Raylib.IsMouseButtonPressed(MouseButton.Left))
            {

                Player.points += Player.playerDamege;


            }



        }
    }





}