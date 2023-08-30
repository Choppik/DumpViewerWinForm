using DumpViewer.Views.Events;
using System;
using System.IO;
using System.Windows.Forms;

namespace DumpViewer.Views.Forms
{
    public partial class DumpHeaderView : Form, IDumpHeaderView
    {
        public DumpHeaderView()
        {
            InitializeComponent();
        }

        public bool IsOpen { get; set; } // false - если файл не открыт, true - если файл открыт 
        public event EventHandler<OpenFileEventArgs> OpenFileEvent;
        protected virtual void OnOpenFile(OpenFileEventArgs e) => OpenFileEvent?.Invoke(this, e);
        public void ShowError(string text) => MessageBox.Show(text, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        public void ShowWarning(string text) => MessageBox.Show(text, "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        public void InsertInTextBox(string dumpFile, string bugCheckString, string bugCheckCode, string parameter1,
            string parameter2, string parameter3, string parameter4, string processor,
            string versionArchitecture, string fullPath, string processorsCount, string majorVersion,
            string minorVersion, string dumpFileSize, string dumpFileTime)
        {
            textBoxDumpFile.Text = dumpFile;
            textBoxBugCheckString.Text = bugCheckString;
            textBoxBugCheckCode.Text = bugCheckCode;
            textBoxParameter1.Text = parameter1;
            textBoxParameter2.Text = parameter2;
            textBoxParameter3.Text = parameter3;
            textBoxParameter4.Text = parameter4;
            textBoxProcessor.Text = processor;
            textBoxVersionArchitecture.Text = versionArchitecture;
            textBoxFullPath.Text = fullPath;
            textBoxProcessorsCount.Text = processorsCount;
            textBoxMajorVersion.Text = majorVersion;
            textBoxMinorVersion.Text = minorVersion;
            textBoxDumpFileSize.Text = dumpFileSize;
            textBoxDumpFileTime.Text = dumpFileTime;
        }
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Filter = "Дампы (*.dmp)|*.dmp;|Все файлы (*.*)|*.*"
            };

            bool dialogResult;
            if (openFile.ShowDialog() == DialogResult.OK) dialogResult = true;
            else return;

            if (dialogResult && Path.GetExtension(openFile.FileName) != ".dmp")
            {
                ShowError("Открыть файл не удалось, так как он не соответствует расширению .dmp.");
                return;
            }

            OnOpenFile(new OpenFileEventArgs(dialogResult, openFile.FileName));
            Panel1_VisibleChanged(sender, e);
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
        private void Panel1_VisibleChanged(object sender, EventArgs e) => panel1.Visible = IsOpen;
    }
}