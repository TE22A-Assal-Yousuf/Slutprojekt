using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class Enemy
{
    public int enmysize = 128;
    public Rectangle enemyRect = new Rectangle(250, 250, 256, 256);
    
    public static double points = 0;
    public double enemyHP = 10;
    public double enemyHPMax = 10;

    private static Font MinecraftFont = Raylib.LoadFont("Minecraft.ttf");
    private static Font MinecrafterFont = Raylib.LoadFont("Minecrafter.Reg.ttf");
    private static Font font = Raylib.LoadFont("Minecraft.ttf");


    public void Draw()
    {

        Raylib.DrawRectangleRec(enemyRect, Color.DarkBlue);
        Raylib.DrawTextEx(MinecrafterFont , "Points:", new Vector2 (330,170) , 20 , 5, Color.Black);
        Raylib.DrawTextEx(MinecraftFont , $"{points}", new Vector2 (280,200) , 50 , 5, Color.Black);

    }
    
   

}