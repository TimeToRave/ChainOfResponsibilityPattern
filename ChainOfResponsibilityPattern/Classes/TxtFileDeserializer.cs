using System;
using System.Xml.Linq;

namespace ChainOfResponsibilityPattern.Classes
{
    public class TxtFileDeserializer : BaseFileDeserializer
    {
             /// <summary>
        /// Валидация txt документа
        /// </summary>
        /// <param name="fileName">Название файла</param>
        /// <param name="request">Входной объект. Ожидается строка</param>
        public override object Handle(object fileName, object request)
        {
            string fileContent = request as string;
            bool isFileValid = Validate(fileContent);

            if (isFileValid)
            {
                string fileExtension = "txt";
                
                Console.WriteLine("Обработчик TXT получил файл");
                SaveFile(fileName.ToString(), fileContent, fileExtension);
                return fileExtension;
            }
            else
            {
                Console.WriteLine("Входной файл не является TXT");
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
           return fileContent.Length > 0;
        }
    }
}