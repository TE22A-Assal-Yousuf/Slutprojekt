using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class Enemy
{
    public int enmysize = 128;
    public Rectangle enemyRect = new Rectangle(250, 250, 256, 256);
    
    public static double points = 0;
    public double enemyHP = 10;
    public double enemyHPMax = 10;

    public void Draw()
    {

        Raylib.DrawRectangleRec(enemyRect, Color.DarkBlue);
        Raylib.DrawText($"Points{points}", 250, 230, 20, Color.Black);


    }
    
   

}