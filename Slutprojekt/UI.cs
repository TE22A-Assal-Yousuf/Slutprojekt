using System.Numerics;

class UI
{
        public void Draw()
        {

                Texture2D GameBackground = Raylib.LoadTexture(@"Gamebackground.png");
                Raylib.DrawTexture(GameBackground, 0, 0, Color.White );




               /* Raylib.DrawRectangle(0, 0, 1280, 32, Color.DarkBrown);//top
                Raylib.DrawRectangle(0, 768, 1280, 32, Color.DarkBrown);//bottom
                Raylib.DrawRectangle(0, 0, 32, 800, Color.DarkBrown);//left
                Raylib.DrawRectangle(800, 0, 800, 800, Color.DarkBrown);//right

                //448 , 736*/

        }

}
public class Store
{
        //Rectangles
        public Rectangle Storebutton = new Rectangle(930, 730, 300, 50);
        public Rectangle Backbutton = new Rectangle(30, 720, 150, 50);
        public Rectangle Buybutton = new Rectangle(400, 720, 400, 50);
        public Rectangle ShopWindow = new Rectangle(40, 40, 1200, 720);
        public Rectangle Background = new Rectangle(0, 0, 1280, 800);

        //Textures
        Texture2D storeblur = Raylib.LoadTexture(@"shop bg.webp");
        Texture2D Backbuttontexture = Raylib.LoadTexture(@"Backbuttontexture.png");
        Texture2D Buybuttontexture = Raylib.LoadTexture(@"Buybuttontexture.png");



        
        GameManager gm = new();
        Player player = new();
        Enemy enemy = new();



        public bool storebuttonispressed = false;
        public bool backbuttonispressed = false;


        Vector2 mousePos = Raylib.GetMousePosition();

         public void Draw()
        {

                Raylib.DrawRectangleRec(Background, Color.DarkBrown);
                Raylib.DrawRectangleRec(ShopWindow, Color.Brown);
                Raylib.DrawTextEx(Damage.MinecraftFont , $"{Damage.points}", new Vector2 (280,20) , 50 , 5, Color.Black);
                Raylib.DrawTextEx(Damage.MinecraftFont , $"{Damage.gems}", new Vector2 (80,20) , 50 , 5, Color.Black);

                
        }
        public void Drawstorebutton()
        {

                Raylib.DrawRectangleRec(Storebutton, Color.Brown);
                Raylib.DrawText("STORE", (int)Storebutton.X, (int)Storebutton.Y + 5, 40, Color.Black);

        }
        public void Drawbackbutton()
        {
                Raylib.DrawRectangleRec(Backbutton, Color.Green);
                Raylib.DrawTexture(Backbuttontexture, (int)Backbutton.X, (int)Backbutton.Y, Color.White );
                //Raylib.DrawText("BACK", (int)Backbutton.X, (int)Backbutton.Y + 5, 40, Color.Black);


        }
        public void DrawBuybutton()
        {
                Raylib.DrawRectangleRec(Buybutton, Color.Brown);
                Raylib.DrawTexture(Buybuttontexture, (int)Buybutton.X, (int)Buybutton.Y, Color.White );
                //Raylib.DrawText("BUY", (int)Buybutton.X, (int)Buybutton.Y + 5, 40, Color.Black);

        }
        public void Button()
        {

                if (Raylib.CheckCollisionPointRec(mousePos, Storebutton))
                {

                        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                        {

                                storebuttonispressed = true;

                        }



                }

                if (Raylib.CheckCollisionPointRec(mousePos, Backbutton))
                {
                        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                        {

                                backbuttonispressed = true;

                        }
                }
                if (Raylib.CheckCollisionPointRec(mousePos, Buybutton))
                {
                        if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                        {
                                Damage.points -= 20;
                                Player.autoDamage += 200;
                        }

                }


        }
       
}
