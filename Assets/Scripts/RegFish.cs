
// RegularFish inherits from Fish
public class RegularFish : Fish
{
    void Start()
    {
        pointValue = 1;
    }
    public override void destroyFish()
    {
        // Implementation to destroy the regular fish
        Destroy(gameObject);
    }
}