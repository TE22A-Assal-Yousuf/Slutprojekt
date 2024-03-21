using System.Numerics;

public class GameManager
{

    public int windowWidth = 1280;
    public int windowHeight = 800;
    public int fps = 60;
    Vector2 mousePos = Raylib.GetMousePosition();



    Characters characters = new();
    Damage damage = new();

    Enemy enemy = new();

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
            Raylib.ClearBackground(Color.Green);

            //UI

            UI ui = new();

            ui.Draw();

            //player stuff
            // Player player = new();

            //enemy stuff
            // Enemy enemy = new();
            enemy.Draw();

            //Damage
            damage.Hit();
            

            //Store
            Store store = new();
            store.Drawstorebutton();
            store.Button();
            if(store.storebuttonispressed == true)
            {

                scene = "shop";

            }
            


            //Other


            

        }
        else if (scene == "shop")
        {
            Raylib.ClearBackground(Color.Blue);

            
            Characters characters = new();

            JuliusC juliusC = new();
            Meo meo = new();

            meo.Draw();
            juliusC.Draw();

            //Store
            Store store = new();
            store.Drawbackbutton();
            store.DrawBuybutton();
            store.Button();
            if(store.backbuttonispressed == true)
            {

                scene = "game";

            }

        }

        return scene;
    }
}
