namespace PW8
{
    public interface IView
    {
        event ViewHandler<IView> Changed;
        void SetController(IController cont);
    }
}
