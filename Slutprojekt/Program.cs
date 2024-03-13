global using Raylib_cs;
using System.Numerics;
using System.Runtime.InteropServices;

GameManager gm = new();
Damage damage = new();

String scene = "game";

gm.Update();

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();

    damage.update();


    scene = gm.Gamemanager(scene);


    Raylib.EndDrawing();
}

