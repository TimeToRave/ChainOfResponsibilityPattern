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
        /// <param name="fileName">Название файла</param>
        /// <param name="request">Входной объект. Ожидается строка</param>
        public override object Handle(object fileName, object request)
        {
            string fileContent = request as string;
            bool isFileValid = Validate(fileContent);

            if (isFileValid)
            {
                SaveFile(fileName.ToString(), fileContent, "json");
                return fileContent;
            }
            else
            {
                Console.WriteLine("Входной файл не является JSON");
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
                var obj = JToken.Parse(fileContent);
                Console.WriteLine("Обработчик JSON получил файл");
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}