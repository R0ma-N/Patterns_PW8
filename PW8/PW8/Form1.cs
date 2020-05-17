using System;
using System.Windows.Forms;

namespace PW8
{
    public partial class Form1 : Form, IView, IModelObserver
    {
        private IController controller;

        public Form1()
        {
            InitializeComponent();
        }

        public event ViewHandler<IView> Changed;

        public void SetController(IController cont)
        {
            controller = cont;
        }

        public void ValueChanged(IModel model, ModelEventArgs e)
        {
            ListBox.Items.Add(e.newValue);
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Changed.Invoke(this, new ViewEventArgs(TextBox.Text));
        }
    }
}
