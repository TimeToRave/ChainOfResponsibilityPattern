using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;

namespace ChainOfResponsibilityPattern.Classes
{
    /// <summary>
    /// Реализует валидацию передаваемой строки как CSV документа
    /// </summary>
    public class CsvFileDeserializer : BaseFileDeserializer
    {
        /// <summary>
        /// Валидация CSV документа
        /// </summary>
        /// <param name="fileName">Название файла</param>
        /// <param name="request">Входной объект. Ожидается строка</param>
        public override object Handle(object fileName, object request)
        {
            string fileContent = request as string;


            using (var parser = new TextFieldParser(GenerateStreamFromString(fileContent)))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                string[] line;
                while (!parser.EndOfData)
                {
                    try
                    {
                        line = parser.ReadFields();

                        Console.WriteLine("Обработчик CSV получил файл");
                        SaveFile(fileName.ToString(), fileContent, "csv");

                        return fileContent;
                    }
                    catch (MalformedLineException)
                    {
                        Console.WriteLine("Входной файл не является CSV");
                        return base.Handle(fileName.ToString(), request);
                    }
                }
            }

            return fileContent;
        }

        /// <summary>
        /// Преобразует строку в поток
        /// </summary>
        /// <param name="str">Исходная строка</param>
        /// <returns>Поток</returns>
        private Stream GenerateStreamFromString(string str)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(str);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }
    }
}