using DumpViewer.Models;
using DumpViewer.Views;
using DumpViewer.Views.Events;
using System;
using System.Collections.ObjectModel;
using System.IO;
using static DumpViewer.Models.SmallMemoryDumpWindows;

namespace DumpViewer.Presenters
{
    /// <summary>
    /// Presenter заголовка дампа.
    /// </summary>
    /// <remarks>
    /// Presenter является связующим между моделью и представление (MVP)
    /// </remarks>
    public class DumpHeaderPresenter
    {
        private DomainModel _model;
        private IDumpHeaderView _view;

        public DumpHeaderPresenter(DomainModel model, IDumpHeaderView view)
        {
            _model = model;
            _view = view;

            _view.OpenFileEvent += ViewOpenFileEvent;
        }

        private void ViewOpenFileEvent(object sender, OpenFileEventArgs e)
        {
            if (e.IsOpenFile)
            {
                string bugCheckString;
                string bugCheckCode;
                string processor;
                string versionArchitecture;
                string fullPath;
                string processorsCount;
                string majorVersion;
                string minorVersion;
                string dumpFileSize;
                string dumpFileTime;
                ObservableCollection<string> parameters = new ObservableCollection<string>();
                FileInfo fileInfo = new FileInfo(e.FullPath);
                var data = _model.FromFile(fileInfo.FullName);

                data.ReadSmallMemoryDumpWindows();

                if (Enum.IsDefined(typeof(BugCheckCodeEnum), data.DumpWindows.BugCheckCode))
                    bugCheckString = data.DumpWindows.BugCheckCode.ToString();
                else bugCheckString = "";
                bugCheckCode = "0x" + ((uint)data.DumpWindows.BugCheckCode).ToString("X8");
                processor = data.DumpWindows.MachineImageType.ToString();
                versionArchitecture = 'x' + data.DumpWindows.VersionArchitecture.ToString();
                fullPath = e.FullPath;
                processorsCount = data.DumpWindows.NumberProcessors.ToString();
                majorVersion = data.DumpWindows.MajorVersion.ToString();
                minorVersion = data.DumpWindows.MinorVersion.ToString();
                dumpFileSize = fileInfo.Length.ToString();
                dumpFileTime = fileInfo.CreationTime.ToString();

                switch (data.DumpWindows.VersionArchitecture)
                {
                    case 64:
                        for (int i = 0; i < data.DumpWindows.BugCheckParameters.Length - 1; i += data.DumpWindows.BugCheckParameters.Length / 4)
                        {
                            parameters.Add(data.DumpWindows.BugCheckParameters[i + 1].ToString("X8") + '`' + data.DumpWindows.BugCheckParameters[i].ToString("X8"));
                        }
                        break;
                    case 32:
                        for (int i = 0; i < data.DumpWindows.BugCheckParameters.Length; i++)
                        {
                            parameters.Add("0x" + data.DumpWindows.BugCheckParameters[i].ToString("X8"));
                        }
                        break;
                    default:
                        break;
                }

                _view.InsertInTextBox(
                    fileInfo.Name,
                    bugCheckString,
                    bugCheckCode,
                    parameters[0],
                    parameters[1],
                    parameters[2],
                    parameters[3],
                    processor,
                    versionArchitecture,
                    fullPath,
                    processorsCount,
                    majorVersion,
                    minorVersion,
                    dumpFileSize,
                    dumpFileTime
                    );
            }
        }
    }
}