public class GameManager{
Enemy enemy = new Enemy();
public static string Gamemanager(string scene)
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

        //player stuff

        Player.Draw();

        //enemy stuff
        Enemy enemy = new();
        enemy.Draw();

    }

    return scene;
}
}
