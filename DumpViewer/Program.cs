using DumpViewer.Models;
using DumpViewer.Presenters;
using DumpViewer.Views.Forms;
using System;
using System.Windows.Forms;

namespace DumpViewer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DumpHeaderView view = new DumpHeaderView();
            DomainModel model = new DomainModel();
            DumpHeaderPresenter presenter = new DumpHeaderPresenter(model, view);
            Application.Run(view);
        }
    }
}