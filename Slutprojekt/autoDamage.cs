public class autoDamage
{
    public autoDamage(Action action, float delay)
    {
        TimeRemaining = delay;
        Action = action;
        Delay = delay;
    }

    public Action Action;
    public float Delay = 1;
    public float TimeRemaining; 

    public bool Update(float deltaTime)
    {
        TimeRemaining -= deltaTime;

        if (TimeRemaining <= 0)
        {
            Damage damage = new();
            damage.autoDMG();
            return false;
        }

        return true;
    }
}