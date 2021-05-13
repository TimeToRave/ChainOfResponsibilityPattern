using System;
using Newtonsoft.Json.Linq;

namespace ChainOfResponsibilityPattern.Classes
{
    /// <summary>
    /// Реализует валидацию передаваемой строки как JSON объекта
    /// </summary>
    public class JsonFileDeserializer : BaseFileDeserializer
    {
        /// <summary>
        /// Валидация JSON объекта
        /// </summary>
        /// <param name="request">Входной объект. Ожидается строка</param>
        public override object Handle(object request)
        {
            string fileContent = request as string;
            try
            {
                var obj = JToken.Parse(fileContent);
                
                Console.WriteLine("Обработчик JSON получил файл");
                SaveFile(fileContent, "json");
                
                return fileContent;
            }
            catch (Exception)
            {
                return base.Handle(request);    
            }
        }
    }
}