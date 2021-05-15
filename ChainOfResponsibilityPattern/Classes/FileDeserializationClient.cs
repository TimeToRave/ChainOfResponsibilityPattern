using ChainOfResponsibilityPattern.Interfaces;

namespace ChainOfResponsibilityPattern.Classes
{
    /// <summary>
    /// Класс для валидации содержимого входного файла
    /// </summary>
    public class FileDeserializationClient
    {
        /// <summary>
        /// Последовательный запуск обработчиков цепочки последовательности
        /// </summary>
        /// <param name="fileName">Название файла</param>
        /// <param name="fileContent">Содержимое файла</param>
        public object Run(string fileName, string fileContent)
        {
            IHandler xmlDeserializer = new XmlFileDeserializer();
            IHandler jsonDeserializer = new JsonFileDeserializer();
            IHandler csvDeserializer = new CsvFileDeserializer();

            jsonDeserializer.NextHandler = csvDeserializer;
            xmlDeserializer.NextHandler = jsonDeserializer;
            
            var result = xmlDeserializer.Handle(fileName, fileContent);
            return result;
        }
    }
}