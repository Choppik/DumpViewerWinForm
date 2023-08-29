using DumpViewer.Services;
using System;
using System.Linq;
using System.Windows.Forms;
using static DumpViewer.Models.SmallMemoryDumpWindows;

namespace DumpViewer.Models
{
    /// <summary>
    /// Доменная модель приложения.
    /// </summary>
    public class DomainModel
    {
        private DumpStreamService _stream;
        private SmallMemoryDumpWindows _dumpWindows;

        private byte[] _signatureCheck = new byte[] { 80, 65, 71, 69 }; //(PAGE) - обозначение сигнатуры в байтах
        private byte[] _validDumpCheck = new byte[] { 68, 85, 77, 80 }; //(DUMP) - обозначение валидации в байтах
        private byte[] _validDu64Check = new byte[] { 68, 85, 54, 52 }; //(DU64) - обозначение валидации в байтах

        /// <summary>
        /// Модель минидампа.
        /// </summary>
        public SmallMemoryDumpWindows DumpWindows { get => _dumpWindows; }

        /// <summary>
        /// Конструктор модели.
        /// </summary>
        /// <param name="stream">Поток, который считывается из файла минидампа</param>
        /// <param name="dumpWindows">Модель, представляющая заголовок минидампа</param>
        public DomainModel(DumpStreamService stream, SmallMemoryDumpWindows dumpWindows)
        {
            _stream = stream;
            _dumpWindows = dumpWindows;
        }
        public DomainModel() { }

        /// <summary>
        /// Создание доменной модели сразу после открытия файла минидампа.
        /// </summary>
        /// <param name="fileName">Путь к файлу</param>
        /// <returns></returns>
        public DomainModel FromFile(string fileName) => new DomainModel(new DumpStreamService(fileName), new SmallMemoryDumpWindows());

        /// <summary>
        /// Чтение байт из потока для получения информации о заголовке минидампа.
        /// </summary>
        public void ReadSmallMemoryDumpWindows()
        {
            var count = 0;
            _dumpWindows.Signature = _stream.ReadBytes(4);
            if (!Enumerable.SequenceEqual(_dumpWindows.Signature, _signatureCheck))
                MessageBox.Show("Открыть файл не удалось, так как он не соответствует сигнатуре PAGE.", "Открытие файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _dumpWindows.ValidDump = _stream.ReadBytes(4);
            if (!Enumerable.SequenceEqual(_dumpWindows.ValidDump, _validDu64Check) && !Enumerable.SequenceEqual(_dumpWindows.ValidDump, _validDumpCheck))
                MessageBox.Show("Открыть файл не удалось, так как в нем нет подписи DU64 или DUMP.", "Открытие файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _dumpWindows.MajorVersion = _stream.ReadU4();
            _dumpWindows.MinorVersion = _stream.ReadU4();

            if (Enumerable.SequenceEqual(_dumpWindows.ValidDump, _validDu64Check))
            {
                _dumpWindows.VersionArchitecture = 64;
                _dumpWindows.DirectoryTableBase = _stream.ReadU8();
                _dumpWindows.PfnDataBase = _stream.ReadU8();
                _dumpWindows.PsLoadedModuleList = _stream.ReadU8();
                _dumpWindows.PsActiveProcessHead = _stream.ReadU8();
                count = 8;
            }
            else if (Enumerable.SequenceEqual(_dumpWindows.ValidDump, _validDumpCheck))
            {
                _dumpWindows.VersionArchitecture = 32;
                _dumpWindows.DirectoryTableBase = _stream.ReadU4();
                _dumpWindows.PfnDataBase = _stream.ReadU4();
                _dumpWindows.PsLoadedModuleList = _stream.ReadU4();
                _dumpWindows.PsActiveProcessHead = _stream.ReadU4();
                count = 4;
            }
            _dumpWindows.MachineImageType = (MachineImageTypeEnum)_stream.ReadU4();
            _dumpWindows.NumberProcessors = _stream.ReadU4();
            _dumpWindows.BugCheckCode = (BugCheckCodeEnum)_stream.ReadU4();
            _dumpWindows.BugCheckParameters = new uint[count];
            for (var i = 0; i < count; i++)
            {
                _dumpWindows.BugCheckParameters[i] = _stream.ReadU4();
                if (_dumpWindows.BugCheckParameters[i] == BitConverter.ToUInt32(_dumpWindows.Signature, 0)) i--; //После кода ошибки (BugCheckCode) встречается сигнатура. Ее можно игнорировать.
            }
        }
    }
}