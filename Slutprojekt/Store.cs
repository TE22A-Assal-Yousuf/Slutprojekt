using System.Numerics;

public class Store
{

    public Rectangle Storebutton = new Rectangle(840, 730, 400, 50);
    public Rectangle Backbutton = new Rectangle(50, 710, 150, 50);
    public Rectangle Buybutton = new Rectangle(400, 710, 400, 50);

    Damage damage = new();
    GameManager gm = new();
    Player player = new();
    Enemy enemy = new();



    public bool storebuttonispressed = false;
    public bool backbuttonispressed = false;
    

    

    public void Drawstorebutton()
    {

        Raylib.DrawRectangleRec(Storebutton, Color.Brown);
        Raylib.DrawText("STORE", (int)Storebutton.X, (int)Storebutton.Y + 5, 40, Color.Black);

    }
    public void Drawbackbutton()
    {

        Raylib.DrawRectangleRec(Backbutton, Color.Brown);
        Raylib.DrawText("BACK", (int)Backbutton.X, (int)Backbutton.Y + 5 , 40, Color.Black);


    }
    public void DrawBuybutton()
    {
        Raylib.DrawRectangleRec(Buybutton, Color.Brown);
        Raylib.DrawText("BUY", (int)Buybutton.X, (int)Buybutton.Y + 5 , 40, Color.Black);

    }
    public void Button()
    {

        if (Raylib.CheckCollisionPointRec(damage.mousePos, Storebutton))
            {

                if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                {

                    storebuttonispressed = true;

                }



            }

        if(Raylib.CheckCollisionPointRec(damage.mousePos, Backbutton))
        {
            if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                {

                     backbuttonispressed= true;

                }
        }
        if(Raylib.CheckCollisionPointRec(damage.mousePos, Storebutton))
        {
            if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                {

                    enemy.points -= 20;
                    enemy.gems -= 20;
                }

        }


    }


}