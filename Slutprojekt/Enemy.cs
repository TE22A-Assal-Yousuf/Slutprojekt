class Enemy
{
    public static Rectangle enemyRect = new Rectangle(250, 250, 64, 64);

    public static int enemyHP = 100;


    public static void Draw()
    {
        
         Raylib.DrawRectangleRec(enemyRect, Color.DarkBlue);
         Raylib.DrawText($"Health{enemyHP}", 250, 230, 20, Color.Black);

    }

}
 
