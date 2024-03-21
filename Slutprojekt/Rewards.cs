using System.ComponentModel;
    using System.Numerics;
    using System.Reflection.PortableExecutable;
    using System.Security.Cryptography.X509Certificates;

class Rewards
{
    Characters characters = new();


    public string name { get; }
    public int damage { get; }

    public Rewards(string name, int damage)
    {

        this.name = name;
        this.damage = damage;

    }

    






}
public class Characters
{

    List<Characters> RewardsList = new List<Characters>();

    public void Characteradd()
    {



    }  


    public void Draw()
    {
        JuliusC juliusC = new();

        juliusC.Draw();
       

    }




}
public class JuliusC
{
    string Name = "Julius";
    int Damage = 10;
    short Stars = 4;
    public Texture2D JuliusTexture = Raylib.LoadTexture(@"Hyper.png");

    public void Draw()
    {


        Raylib.DrawTexture(JuliusTexture, 40, 60, Color.White);



    }

}
public class Meo
{
    string Name = "Meo";
    int Damage = 10;
    short Stars = 4;
    public Texture2D MeoTexture = Raylib.LoadTexture(@"Meo.png");

    public void Draw()
    {


        Raylib.DrawTexture(MeoTexture, 480, 63, Color.White);



    }

}






