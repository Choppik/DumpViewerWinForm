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

        public DumpHeaderPresenter(DomainModel model, IDumpHeaderView view) //В Presenter передается модель и представление
        {
            _model = model;
            _view = view;

            _view.OpenFileEvent += ViewOpenFileEvent;
        }

        private void ViewOpenFileEvent(object sender, OpenFileEventArgs e) //Обработка события открытия файла
        {
            if (e.IsOpenFile)
            {
                string bugCheckString;
                ObservableCollection<string> parameters = new ObservableCollection<string>();
                FileInfo fileInfo = new FileInfo(e.FullPath);
                var data = _model.FromFile(fileInfo.FullName);

                data.ReadSmallMemoryDumpWindows();

                if (data.ErrorCheck)
                {
                    _view.ShowError(data.Error.Message);
                    return;
                }

                if (Enum.IsDefined(typeof(BugCheckCodeEnum), data.DumpWindows.BugCheckCode))
                    bugCheckString = data.DumpWindows.BugCheckCode.ToString();
                else bugCheckString = "";
                string bugCheckCode = "0x" + ((uint)data.DumpWindows.BugCheckCode).ToString("X8");
                string processor = data.DumpWindows.MachineImageType.ToString();
                string versionArchitecture = 'x' + data.DumpWindows.VersionArchitecture.ToString();
                string fullPath = e.FullPath;
                string processorsCount = data.DumpWindows.NumberProcessors.ToString();
                string majorVersion = data.DumpWindows.MajorVersion.ToString();
                string minorVersion = data.DumpWindows.MinorVersion.ToString();
                string dumpFileSize = fileInfo.Length.ToString();
                string dumpFileTime = fileInfo.CreationTime.ToString();

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

                _view.IsOpen = true;
            }
        }
    }
}