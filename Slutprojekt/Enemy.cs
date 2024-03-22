using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class Enemy
{
    Player player = new();
    //enemy
    public int enmysize = 128;
    public Rectangle enemyRect = new Rectangle(285, 330, 256, 256);

    
    public static Texture2D emntexture = Raylib.LoadTexture(@"Balltexture.png");
    //points

    //font 





    public void Draw()
    {

        //enemy/cllicky

        Raylib.DrawRectangleRec(enemyRect, Color.Blank);
        Raylib.DrawTexture(emntexture, (int)enemyRect.X, (int)enemyRect.Y, Color.White );

        //points stuff
        

        

    }
    
   

}