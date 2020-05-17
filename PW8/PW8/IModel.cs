namespace PW8
{
    public interface IModel
    {
        void Attach(IModelObserver imo);
        void AddNewValue(string nValue);
    }
}
