using System.ComponentModel;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

class Rewards
{
    Vector2 mousePos = Raylib.GetMousePosition();

    public static List<Upgrades> UpgradesList = new List<Upgrades>();

    public void start()
    {

        Upgrades StrawHat = new Upgrades("Straw Hat", 0, 20, 1, Upgrades.Upgr1button);
        Upgrades Zanpakuto = new Upgrades("Zanpakuto", 0, 100, 5, Upgrades.Upgr2button);
        Upgrades DeathNote = new Upgrades("Death Note", 0, 1000, 20, Upgrades.Upgr3button);

        UpgradesList.Add(StrawHat);
        UpgradesList.Add(Zanpakuto);
        UpgradesList.Add(DeathNote);


        //strawhat
        Raylib.DrawRectangleRec(UpgradesList[0].Rectangle, Color.Brown);
        Raylib.DrawText($"{UpgradesList[0].Name}", (int)Upgrades.Upgr1button.X + 5, (int)Upgrades.Upgr1button.Y + 5, 20, Color.Black);
        Raylib.DrawText($"Price: {UpgradesList[0].Price}$", (int)Upgrades.Upgr1button.X + 150, (int)Upgrades.Upgr1button.Y + 15, 20, Color.Black);
        Raylib.DrawText($"Count: {UpgradesList[0].Count}", (int)Upgrades.Upgr1button.X + 5, (int)Upgrades.Upgr1button.Y + 35, 10, Color.Black);

        //Zanpakuto

        Raylib.DrawRectangleRec(UpgradesList[1].Rectangle, Color.Brown);
        Raylib.DrawText($"{UpgradesList[1].Name}", (int)Upgrades.Upgr2button.X + 5, (int)Upgrades.Upgr2button.Y + 5, 20, Color.Black);
        Raylib.DrawText($"Price: {UpgradesList[1].Price}$", (int)Upgrades.Upgr2button.X + 150, (int)Upgrades.Upgr2button.Y + 15, 20, Color.Black);
        Raylib.DrawText($"Count: {UpgradesList[1].Count}", (int)Upgrades.Upgr2button.X + 5, (int)Upgrades.Upgr2button.Y + 35, 10, Color.Black);

        //
        if (Upgrades.unlocked3 == true)
        {
            Raylib.DrawRectangleRec(UpgradesList[2].Rectangle, Color.Brown);
            Raylib.DrawText($"{UpgradesList[2].Name}", (int)Upgrades.Upgr3button.X + 5, (int)Upgrades.Upgr3button.Y + 5, 20, Color.Black);
            Raylib.DrawText($"Price: {UpgradesList[2].Price}$", (int)Upgrades.Upgr3button.X + 150, (int)Upgrades.Upgr3button.Y + 15, 20, Color.Black);
            Raylib.DrawText($"Count: {UpgradesList[2].Count}", (int)Upgrades.Upgr3button.X + 5, (int)Upgrades.Upgr3button.Y + 35, 10, Color.Black);
        }




    }




    public void Upgradebuttons()
    {

        //Straw Hat

        if (Raylib.CheckCollisionPointRec(mousePos, Upgrades.Upgr1button))
        {
            if (Damage.points >= UpgradesList[0].Price)
            {
                if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                {
                    Damage.points -= UpgradesList[0].Price;

                    UpgradesList[0].Price += UpgradesList[0].Price / 100 * 15;
                    UpgradesList[0].Count++;

                    //
                    Player.autoDamage += UpgradesList[0].Upgradestat;

                    UpgradesList[0].Price = Math.Ceiling(UpgradesList[0].Price);


                }
            }
        }

        //Zanpakuto

        if (Raylib.CheckCollisionPointRec(mousePos, Upgrades.Upgr2button))
        {
            if (Damage.points >= UpgradesList[1].Price)
            {
                if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                {
                    Damage.points -= UpgradesList[1].Price;

                    UpgradesList[1].Price += UpgradesList[1].Price / 100 * 15;
                    UpgradesList[1].Count++;

                    //
                    Player.autoDamage += UpgradesList[1].Upgradestat;

                    UpgradesList[1].Price = Math.Ceiling(UpgradesList[1].Price);


                }
            }
        }

        if (Raylib.CheckCollisionPointRec(mousePos, Upgrades.Upgr3button))
        {
            if (Damage.points >= UpgradesList[2].Price)
            {
                if (Raylib.IsMouseButtonPressed(MouseButton.Left))
                {
                    Damage.points -= UpgradesList[2].Price;

                    UpgradesList[2].Price += UpgradesList[2].Price / 100 * 15;
                    UpgradesList[2].Count++;

                    //
                    Player.autoDamage += UpgradesList[2].Upgradestat;

                    UpgradesList[2].Price = Math.Ceiling(UpgradesList[2].Price);


                }
            }
        }

        if (Damage.points >= 1000)
        {
            Upgrades.unlocked3 = true;
        }




    }

}
public class Upgrades
{
    private string name;
    private int count;
    private double price;

    private double upgradestat;

    private Rectangle rectangle;


    public static Rectangle Upgr1button = new Rectangle(930, 200, 300, 50);
    public static Rectangle Upgr2button = new Rectangle(930, 275, 300, 50);
    public static Rectangle Upgr3button = new Rectangle(930, 350, 300, 50);
    public static Rectangle Upgr4button = new Rectangle(930, 425, 300, 50);

    public static bool unlocked3 = false;


    public Upgrades(string name, int count, double price, double upgradestat, Rectangle rectangle)
    {
        this.name = name;
        this.count = count;
        this.price = price;
        this.upgradestat = upgradestat;
        this.rectangle = rectangle;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Count
    {
        get { return count; }
        set { count = value; }
    }
    public double Price
    {
        get { return price; }
        set { price = value; }
    }
    public double Upgradestat
    {
        get { return upgradestat; }
        set { upgradestat = value; }
    }
    public Rectangle Rectangle
    {
        get { return rectangle; }
        set { rectangle = value; }
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


    }




}







