using System;
using System.Text;

namespace DumpViewer.Exceptions
{
    /// <summary>
    /// Исключение, если значения при сравнении будут не совпадать
    /// </summary>
    public class ValidationNotEqualError : Exception
    {
        public ValidationNotEqualError(string message, byte[] expectationValue, byte[] actualValue) 
            : base(message + " Ожидается: " + Encoding.ASCII.GetString(expectationValue) + "; Фактически: " + Encoding.ASCII.GetString(actualValue))
        {
            ExpectationValue = expectationValue;
            ActualValue = actualValue;
        }

        /// <summary>
        /// Значение, которое ожидается.
        /// </summary>
        public byte[] ExpectationValue { get; }
        /// <summary>
        /// Фактическое значение.
        /// </summary>
        public byte[] ActualValue { get; }
    }
}