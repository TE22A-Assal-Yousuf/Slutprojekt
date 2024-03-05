public class GameManager{
Enemy enemy = new Enemy();
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
        damage.autoDMG();

        
        

    }

    return scene;
}
}
