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
        /// <param name="request">Входной объект. Ожидается строка</param>
        public override object Handle(object request)
        {
            string fileContent = request as string;
            try
            {
                XDocument xml = XDocument.Parse(fileContent ?? string.Empty);
                Console.WriteLine("Обработчик XML получил файл");
                SaveFile(fileContent, "xml");
                return fileContent;
            }
            catch (Exception)
            {
                return base.Handle(request);    
            }
        }
    }
}