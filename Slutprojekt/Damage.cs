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

                points += player.playerDamege;

            }

        }
    }
    public void update()
    {

        autodamagedelay += Raylib.GetFrameTime();

        if (autodamagedelay > 1)
        {

            autodamagedelay = 0;

            points += 1;

        }

            
    }
    public void Draw()
    {
        Raylib.DrawTextEx(MinecrafterFont , "Points:", new Vector2 (330,170) , 20 , 5, Color.White);
        Raylib.DrawTextEx(MinecraftFont , $"{points}", new Vector2 (280,200) , 50 , 5, Color.White);
        Raylib.DrawTextEx(MinecraftFont , $"{gems}", new Vector2 (100,80) , 50 , 5, Color.White);

    }

}
