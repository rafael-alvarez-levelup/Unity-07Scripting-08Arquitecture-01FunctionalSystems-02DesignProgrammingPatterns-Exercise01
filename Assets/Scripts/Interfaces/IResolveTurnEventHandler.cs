public interface IResolveTurnEventHandler
{
    public delegate void ResolveTurnEventHandler();
    public event ResolveTurnEventHandler OnResolveTurn;
}