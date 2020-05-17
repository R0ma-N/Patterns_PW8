using System.Collections.Generic;

namespace PW8
{
    public class ListModel : IModel
    {
        public event ModelHandler<ListModel> Changed;
        private List<string> list;
        public ListModel() => list = new List<string>();

        public void AddNewValue(string nValue)
        {
            list.Add(nValue);
            Changed.Invoke(this, new ModelEventArgs(nValue));
        }

        public void Attach(IModelObserver imo) => Changed += new ModelHandler<ListModel>(imo.ValueChanged);
    }
}
