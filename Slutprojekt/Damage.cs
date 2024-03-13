using System.Numerics;
using System.Security.Cryptography.X509Certificates;
class Damage
{
    Enemy enemy = new();
    Player damage = new();

    Vector2 mousePos = Raylib.GetMousePosition();
    float autodamagedelay = 0;

    public void Hit()
    {


        if (Raylib.CheckCollisionPointRec(mousePos, enemy.enemyRect))
        {

            if (Raylib.IsMouseButtonPressed(MouseButton.Left))
            {

                Enemy.points += damage.playerDamege;


            }



        }
    }
    public void update()
    {

        autodamagedelay += Raylib.GetFrameTime();

        if (autodamagedelay > 1)
        {

            autodamagedelay = 0;

            if (Enemy.points >= 0)
            {

            Enemy.points += damage.autoDamage;

            }



        }



    }

}
