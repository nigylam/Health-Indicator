public class Decreaser : StatAffector
{
    public override void OnClick()
    {
        Health.Decrease(Value);
    }
}
