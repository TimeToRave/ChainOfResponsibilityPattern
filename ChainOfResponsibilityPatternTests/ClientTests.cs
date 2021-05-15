using ChainOfResponsibilityPattern.Classes;
using NUnit.Framework;

namespace ChainOfResponsibilityPatternTests
{
    [TestFixture]
    public class ClientTests
    {
        private string xml = "<note><to>Tove</to><from>Jani</from><heading>Reminder</heading><body>Don't forget me this weekend!</body></note>";
        private string json = "{\"data\":\"Click Here\",\"size\":36,\"style\":\"bold\"}";
        private string csv = "Иванов,25\nПетров,30";
        
        /// <summary>
        /// Проверяет класс валидации строки
        /// На вход подается XML
        /// </summary>
        [Test]
        public void FileDeserializationClient_Xml()
        {
            var client = new FileDeserializationClient();
            string result = client.Run("test", xml).ToString();

            string etalon = "xml";

            Assert.AreEqual(etalon, result);
        }
        
        /// <summary>
        /// Проверяет класс валидации строки
        /// На вход подается JSON
        /// </summary>
        [Test]
        public void FileDeserializationClient_Json()
        {
            var client = new FileDeserializationClient();
            string result = client.Run("test", json).ToString();

            string etalon = "json";

            Assert.AreEqual(etalon, result);
        }
        
        /// <summary>
        /// Проверяет класс валидации строки
        /// На вход подается CSV
        /// </summary>
        [Test]
        public void FileDeserializationClient_Csv()
        {
            var client = new FileDeserializationClient();
            string result = client.Run("test", csv).ToString();

            string etalon = "csv";

            Assert.AreEqual(etalon, result);
        }
        
        /// <summary>
        /// Проверяет класс валидации строки
        /// На вход подается пустая строка
        /// </summary>
        [Test]
        public void FileDeserializationClient_EmptyString()
        {
            var client = new FileDeserializationClient();
            var result = client.Run("test", string.Empty);
            
            Assert.IsNull(result);
        }
        
        /// <summary>
        /// Проверяет класс валидации строки
        /// На вход подается строка неопределенного формата
        /// </summary>
        [Test]
        public void FileDeserializationClient_NonFormattedString()
        {
            var client = new FileDeserializationClient();
            string result = client.Run("test", "OrdinaryString").ToString();

            string etalon = "csv";

            Assert.AreEqual(etalon, result);
        }
    }
}