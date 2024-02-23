global using Raylib_cs;
using System.Numerics;
using System.Runtime.InteropServices;

int windowWidth = 1280;
int windowHeight = 800;
int fps = 60;

Raylib.InitWindow(windowWidth, windowHeight, "Clickyballs");
Raylib.SetTargetFPS(fps);

String scene = "start";
Enemy enemy = new();

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();

    scene = Gamemanager(scene);

    Raylib.EndDrawing();


}

static string Gamemanager(string scene)
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


        Enemy.Draw();

    }

    return scene;
}