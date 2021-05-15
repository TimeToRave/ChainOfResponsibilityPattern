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
            try
            {
                XDocument xml = XDocument.Parse(fileContent ?? string.Empty);
                Console.WriteLine("Обработчик XML получил файл");
                SaveFile(fileName.ToString(), fileContent, "xml");
                return fileContent;
            }
            catch (Exception)
            {
                Console.WriteLine("Входной файл не является XML");
                return base.Handle(fileName.ToString(), request);    
            }
        }
    }
}