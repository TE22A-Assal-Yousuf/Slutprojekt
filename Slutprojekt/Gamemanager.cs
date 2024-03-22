using System.Numerics;

public class GameManager
{


    Vector2 mousePos = Raylib.GetMousePosition();

    Enemy enemy = new Enemy();

    Player player = new Player();







    public void Update()
    {
    }
    public string Gamemanager(string scene)
    {
        if (scene == "start")
        {


            

        }

        else if (scene == "game")
        {

            //UI

        



            //Other




        }
        else if (scene == "shop")
        {

            //Store

            

            
            //Characters characters = new();

            /* JuliusC juliusC = new();
                Meo meo = new();

                meo.Draw();
                juliusC.Draw();*/


        }

        return scene;
    }
}
