using System.Numerics;
using System.Security.Cryptography.X509Certificates;
public class Damage
{
    Enemy enemy = new Enemy();
    Player player = new Player();
    public static double points = 0;
    public static double gems = 500;



    Vector2 mousePos = Raylib.GetMousePosition();
    float autodamagedelay = 0;
    public static Font MinecraftFont = Raylib.LoadFont("Minecraft.ttf");
    public static Font MinecrafterFont = Raylib.LoadFont("Minecrafter.Reg.ttf");
    public static Font NeonGlowFont = Raylib.LoadFont("Neon Glow.ttf");


    public void Hit()
    {

        if (Raylib.CheckCollisionPointRec(mousePos, enemy.enemyRect))
        {

            if (Raylib.IsMouseButtonPressed(MouseButton.Left))
            {

                points += Player.playerDamege;

            }

        }
    }
    public void update()
    {

        autodamagedelay += Raylib.GetFrameTime();

        if (autodamagedelay > 1)
        {

            autodamagedelay = 0;

            points += Player.autoDamage;

        }

            
    }
    public void Draw()
    {
        Raylib.DrawTextEx(MinecrafterFont , "Points:", new Vector2 (330,250) , 20 , 5, Color.White);
        Raylib.DrawTextEx(MinecraftFont , $"{points}", new Vector2 (280,270) , 50 , 5, Color.White);
        Raylib.DrawTextEx(MinecraftFont , $"Gems: {gems}", new Vector2 (925,80) , 50 , 5, Color.White);

    }

}
