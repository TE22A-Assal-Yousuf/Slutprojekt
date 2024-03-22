using System.Numerics;

public class GameManager
{

    public int windowWidth = 1280;
    public int windowHeight = 800;
    public int fps = 60;
    Vector2 mousePos = Raylib.GetMousePosition();



    Characters characters = new();
    Enemy enemy = new Enemy();




    public void Update()
    {
        Raylib.InitWindow(windowWidth, windowHeight, "Clickyballs");
        Raylib.SetTargetFPS(fps);
    }
    public string Gamemanager(string scene)
    {
        if (scene == "start")
        {

            Raylib.ClearBackground(Color.Purple);

            if (Raylib.IsKeyPressed(KeyboardKey.Space))
            {
                scene = "game";
            }

        }

        else if (scene == "game")
        {

            //UI

            UI ui = new();

            ui.Draw();

            //player stuff
            // Player player = new();

            //enemy stuff
            // Enemy enemy = new();
            enemy.Draw();

            //Damage
            Damage damage = new();
            damage.Hit();
            damage.Draw();


            //Store
            Store store = new();
            store.Drawstorebutton();
            store.Button();
            if (store.storebuttonispressed == true)
            {

                scene = "shop";

            }



            //Other




        }
        else if (scene == "shop")
        {

            //Store
            Store store = new();
            store.Draw();
            store.Drawbackbutton();
            store.DrawBuybutton();
            store.Button();
            if (store.backbuttonispressed == true)
            {

                scene = "game";

            }

            Characters characters = new();

            JuliusC juliusC = new();
            Meo meo = new();

            meo.Draw();
            juliusC.Draw();


        }

        return scene;
    }
}
