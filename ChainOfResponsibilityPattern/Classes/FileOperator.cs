using System;
using System.IO;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// Класс работы с файловой системой
    /// </summary>
    public class FileOperator
    {
        /// <summary>
        /// Записывает строку в файл
        /// </summary>
        /// <param name="filePath">Адрес файла</param>
        /// <param name="content">Записыаемое содержимое
        /// </param>
        public void WriteTextToFile(string filePath, string content)
        {
            try
            {
                File.WriteAllText(filePath, content);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"{filePath} file doesn't exists");
            }
        }
    }
}