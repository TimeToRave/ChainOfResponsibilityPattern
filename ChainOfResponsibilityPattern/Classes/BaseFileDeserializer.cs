using ChainOfResponsibilityPattern.Interfaces;

namespace ChainOfResponsibilityPattern.Classes
{
    /// <summary>
    /// Реализует последовательную проверку содержимого файла
    /// для распознания его формата 
    /// </summary>
    public class BaseFileDeserializer : IHandler
    {
        /// <summary>
        /// Следуюший обработчик
        /// </summary>
        public IHandler NextHandler { get; set; }

        /// <summary>
        /// Выполняет обработку входного файла
        /// </summary>
        /// <param name="fileName">Название файла</param>
        /// <param name="request">Содержимое файла</param>
        /// <returns></returns>
        public virtual object Handle(object fileName, object request)
        {

            if (NextHandler != null)
            {
                return NextHandler.Handle(
                    fileName.ToString(),
                    request);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Выполняет сохранение содержимого
        /// файла с заданным расширением
        /// </summary>
        /// <param name="fileContent">Содержимое файла</param>
        /// <param name="fileExtension">Расширение выходного файла</param>
        public void SaveFile(string fileName, string fileContent, string fileExtension)
        {
            FileOperator fileOperator = new FileOperator();
            fileOperator.WriteTextToFile($"{fileName}.{fileExtension}", fileContent);
        } 
    }
}