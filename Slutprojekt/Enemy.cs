using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class Enemy
{
    Player player = new();
    //enemy
    public int enmysize = 128;
    public Rectangle enemyRect = new Rectangle(285, 250, 256, 256);

    Texture2D emntexture = Raylib.LoadTexture(@"Balltexture.png");
    
    //points

    //font 





    public void Draw()
    {

        //enemy/cllicky
        Raylib.DrawTexture(emntexture, (int)enemyRect.X, (int)enemyRect.Y, Color.White );

        Raylib.DrawRectangleRec(enemyRect, Color.Gray);

        //points stuff
        

        

    }
    
   

}