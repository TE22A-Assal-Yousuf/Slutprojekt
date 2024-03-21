using System.Numerics;
using System.Security.Cryptography.X509Certificates;
public class Damage
{
    Enemy enemy = new();
    Player player = new();

    public Vector2 mousePos = Raylib.GetMousePosition();
    float autodamagedelay = 0;

    public void Hit()
    {

        if (Raylib.CheckCollisionPointRec(mousePos, enemy.enemyRect))
        {

            if (Raylib.IsMouseButtonPressed(MouseButton.Left))
            {

                enemy.points += player.playerDamege;

            }

        }
    }
    public void update()
    {

        autodamagedelay += Raylib.GetFrameTime();

        if (autodamagedelay > 1)
        {

            autodamagedelay = 0;

            enemy.points += 1;

        }

            
    }

}
