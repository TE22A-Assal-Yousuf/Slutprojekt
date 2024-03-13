public class GameManager{

public int windowWidth = 1280;
public int windowHeight = 800;
public int fps = 60;



Enemy enemy = new Enemy();

public void Update(){
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


        //enemy stuff
        Enemy enemy = new();
        enemy.Draw();

        //Damage
        Damage damage = new();
        damage.Hit();
        
        

    }

    return scene;
}
}
