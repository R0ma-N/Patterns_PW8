namespace PW8
{
    public interface IModelObserver
    {
        void ValueChanged(IModel model, ModelEventArgs e);
    }
}
