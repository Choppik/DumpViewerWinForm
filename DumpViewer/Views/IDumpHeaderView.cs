using DumpViewer.Views.Events;
using System;

namespace DumpViewer.Views
{
    /// <summary>
    /// Интерфейс представления заголовка дампа
    /// </summary>
    /// <remarks>
    /// Интерфейс используется для уменьшения зависимостей между классами
    /// </remarks>
    public interface IDumpHeaderView
    {
        /// <summary>
        /// Проверка. Открыт ли файл.
        /// </summary>
        bool IsOpen { get; set; }
        /// <summary>
        /// Отобразить предупреждение.
        /// </summary>
        /// <param name="text">Текст сообщения</param>
        void ShowWarning(string text);
        /// <summary>
        /// Отобразить ошибку.
        /// </summary>
        /// <param name="text">Текст ошибки</param>
        void ShowError(string text);
        /// <summary>
        /// Событие, срабатывающее при открытии файла
        /// </summary>
        event EventHandler<OpenFileEventArgs> OpenFileEvent;
        /// <summary>
        /// Заполнение текстовых полей
        /// </summary>
        /// <param name="dumpFile">Название файла</param>
        /// <param name="bugCheckString">Название ошибки</param>
        /// <param name="bugCheckCode">Код ошибки</param>
        /// <param name="parameter1">Параметр 1 ошибки</param>
        /// <param name="parameter2">Параметр 2 ошибки</param>
        /// <param name="parameter3">Параметр 3 ошибки</param>
        /// <param name="parameter4">Параметр 4 ошибки</param>
        /// <param name="processor">Название процессора</param>
        /// <param name="versionArchitecture">Версия архитектуры</param>
        /// <param name="fullPath">Полный путь к файлу</param>
        /// <param name="processorsCount">Количество процессоров</param>
        /// <param name="majorVersion">Мажорная версия системы</param>
        /// <param name="minorVersion">Минорная версия системы</param>
        /// <param name="dumpFileSize">Размер файла</param>
        /// <param name="dumpFileTime">Время изменения файла</param>
        void InsertInTextBox(string dumpFile, string bugCheckString, string bugCheckCode, string parameter1, 
            string parameter2, string parameter3, string parameter4, string processor, 
            string versionArchitecture, string fullPath, string processorsCount, string majorVersion, 
            string minorVersion, string dumpFileSize, string dumpFileTime);
    }
}