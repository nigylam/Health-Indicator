public class Increaser : StatAffector
{
    public override void OnClick()
    {
        Health.TryIncrease(Value);
    }
}
