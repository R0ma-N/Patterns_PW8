using System;
using System.Windows.Forms;

namespace PW8
{
    static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 view = new Form1();
            IModel mdl = new ListModel();
            IController cnt = new ListController(view, mdl);

            Application.Run(view);
        }
    }
}
