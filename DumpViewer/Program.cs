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
            DumpHeaderViewerView view = new DumpHeaderViewerView();
            DomainModel model = new DomainModel();
            DumpHeaderPresenter presenter = new DumpHeaderPresenter(model, view);
            Application.Run(view);
        }
    }
}