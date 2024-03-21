using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class Enemy
{
    Player player = new();
    //enemy
    public int enmysize = 128;
    public Rectangle enemyRect = new Rectangle(285, 250, 256, 256);
    
    //points

    //font 





    public void Draw()
    {

        //enemy/cllicky
        Raylib.DrawRectangleRec(enemyRect, Color.Gray);

        //points stuff
        

        

    }
    
   

}