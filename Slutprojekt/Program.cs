global using Raylib_cs;
using System.Numerics;
using System.Runtime.InteropServices;

int windowWidth = 1280;
int windowHeight = 800;
int fps = 60;

GameManager gm = new();

Raylib.InitWindow(windowWidth, windowHeight, "Clickyballs");
Raylib.SetTargetFPS(fps);

String scene = "game";


while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();

    scene = gm.Gamemanager(scene);

    Raylib.EndDrawing();
}

