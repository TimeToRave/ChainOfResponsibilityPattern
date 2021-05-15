using System;
using System.Xml.Linq;

namespace ChainOfResponsibilityPattern.Classes
{
    /// <summary>
    /// Реализует валидацию передаваемой строки как XML документа
    /// </summary>
    public class XmlFileDeserializer : BaseFileDeserializer
    {
        /// <summary>
        /// Валидация XML документа
        /// </summary>
        /// <param name="fileName">Название файла</param>
        /// <param name="request">Входной объект. Ожидается строка</param>
        public override object Handle(object fileName, object request)
        {
            string fileContent = request as string;
            bool isFileValid = Validate(fileContent);

            if (isFileValid)
            {
                string fileExtension = "xml";
                
                Console.WriteLine("Обработчик XML получил файл");
                SaveFile(fileName.ToString(), fileContent, fileExtension);
                return fileExtension;
            }
            else
            {
                Console.WriteLine("Входной файл не является XML");
                return base.Handle(fileName.ToString(), request);
            }
        }

        /// <summary>
        /// Валидирует XML документ
        /// </summary>
        /// <param name="fileContent">Документ на валидацию</param>
        /// <returns>Результат валидации</returns>
        public bool Validate(string fileContent)
        {
            try
            {
                XDocument xml = XDocument.Parse(fileContent ?? string.Empty);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
