using System.ComponentModel;
using System.Numerics;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

class Rewards
{

    private string name;
    private short dps;
    private short stars;
    private Texture2D rewardtexture;




     public Rewards (string name, short dps, short stars)
    {
        this.name = name;
        this.dps = dps;
        this.Stars = stars;
        
    }

    public string Name
    {
        get { return name;  }
        set { name = value; }
    }

    public short DPS
    {
        get { return dps; }
        set { dps = value; }
    }
    public short Stars
    {
        get { return stars; }
        set { stars = value; }
    }
    public Texture2D RewardTextures
    {
        get { return rewardtexture; }
        set { rewardtexture = value; }
    }
   
    

    
    
    List<Rewards> rewardsList = new List<Rewards>();
    

    

    






}