using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class Enemy
{
    Player player = new();
    //enemy
    public int enmysize = 128;
    public Rectangle enemyRect = new Rectangle(285, 250, 256, 256);
    
    //points
    public double points = 0;
    public double gems = 500;

    //font 
    private static Font MinecraftFont = Raylib.LoadFont("Minecraft.ttf");
    private static Font MinecrafterFont = Raylib.LoadFont("Minecrafter.Reg.ttf");
    private static Font font = Raylib.LoadFont("Minecraft.ttf");




    public void Draw()
    {

        //enemy/cllicky
        Raylib.DrawRectangleRec(enemyRect, Color.Gray);

        //points stuff
        Raylib.DrawTextEx(MinecrafterFont , "Points:", new Vector2 (330,170) , 20 , 5, Color.Black);
        Raylib.DrawTextEx(MinecraftFont , $"{points}", new Vector2 (280,200) , 50 , 5, Color.Black);
        Raylib.DrawTextEx(MinecraftFont , $"{gems}", new Vector2 (100,80) , 50 , 5, Color.Black);

        

    }
    
   

}