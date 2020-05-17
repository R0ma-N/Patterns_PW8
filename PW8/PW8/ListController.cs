namespace PW8
{
    public class ListController : IController
    {
        private IView view;
        private IModel model;

        public ListController(IView v, IModel m)
        {
            view = v;
            model = m;
            view.SetController(this);
            model.Attach((IModelObserver)view);
            view.Changed += new ViewHandler<IView>(this.ViewChanged);
        }

        public void ViewChanged(IView v, ViewEventArgs e) => model.AddNewValue(e.value);
        public void AddValue(string value) => model.AddNewValue(value);
    }
}
