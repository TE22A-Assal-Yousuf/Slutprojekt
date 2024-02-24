class Player
{
    public static double playerDamege = 1;
    public static double autoDamage = 0; 

    public static double points = 0;

    public static void Draw()
    {
        
         Raylib.DrawText($"Points{points}", 10, 21, 20, Color.Black);

    }


    


}