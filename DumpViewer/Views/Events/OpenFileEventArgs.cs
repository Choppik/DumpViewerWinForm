using System;

namespace DumpViewer.Views.Events
{
    public class OpenFileEventArgs : EventArgs
    {
        public OpenFileEventArgs(bool isOpenFile, string fullPath)
        {
            IsOpenFile = isOpenFile;
            FullPath = fullPath;
        }

        public bool IsOpenFile { get; private set; }
        public string FullPath { get; private set; }
    }
}