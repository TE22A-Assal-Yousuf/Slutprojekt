using System.Numerics;
using System.Security.Cryptography.X509Certificates;
class Damage
{
    Player player = new();
    Enemy enemy = new();
    Vector2 mousePos = Raylib.GetMousePosition();
    public void Hit()
    {


        if (Raylib.CheckCollisionPointRec(mousePos, enemy.enemyRect))
        {

            if (Raylib.IsMouseButtonPressed(MouseButton.Left))
            {

                Enemy.points += Player.playerDamege;


            }



        }
    }

    public void autoDMG()
    {
        Enemy.points += Player.autoDamage / 60;
    }
}
