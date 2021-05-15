using ChainOfResponsibilityPattern.Classes;
using Newtonsoft.Json;
using NUnit.Framework;

namespace ChainOfResponsibilityPatternTests
{
    public class DeserializationTests
    {
        private string xml = "<note><to>Tove</to><from>Jani</from><heading>Reminder</heading><body>Don't forget me this weekend!</body></note>";
        private string json = "{\"data\":\"Click Here\",\"size\":36,\"style\":\"bold\"}";
        private string csv = "Иванов,25\nПетров,30";
           
        /// <summary>
        /// Проверяет XML валидитор
        /// На вход подается XML
        /// </summary>
        [Test]
        public void XmlFileDeserializer_Xml()
        {
            var xmlFileDeserializer = new XmlFileDeserializer();
            bool validationResult = xmlFileDeserializer.Validate(xml);
            
            Assert.IsTrue(validationResult);
        }
        
        /// <summary>
        /// Проверяет XML валидитор
        /// На вход подается JSON
        /// </summary>
        [Test]
        public void XmlFileDeserializer_Json()
        {
            var xmlFileDeserializer = new XmlFileDeserializer();
            bool validationResult = xmlFileDeserializer.Validate(json);
            
            Assert.IsFalse(validationResult);
        }
        
        /// <summary>
        /// Проверяет XML валидитор
        /// На вход подается CSV
        /// </summary>
        [Test]
        public void XmlFileDeserializer_Csv()
        {
            var xmlFileDeserializer = new XmlFileDeserializer();
            bool validationResult = xmlFileDeserializer.Validate(csv);
            
            Assert.IsFalse(validationResult);
        }
        
        /// <summary>
        /// Проверяет JSON валидитор
        /// На вход подается XML
        /// </summary>
        [Test]
        public void JsonFileDeserializer_Xml()
        {
            var fileDeserializer = new JsonFileDeserializer();
            bool validationResult = fileDeserializer.Validate(xml);
            
            Assert.IsFalse(validationResult);
        }
        
        /// <summary>
        /// Проверяет JSON валидитор
        /// На вход подается JSON
        /// </summary>
        [Test]
        public void JsonFileDeserializer_Json()
        {
            var xmlFileDeserializer = new JsonFileDeserializer();
            bool validationResult = xmlFileDeserializer.Validate(json);
            
            Assert.IsTrue(validationResult);
        }
        
        /// <summary>
        /// Проверяет JSON валидитор
        /// На вход подается CSV
        /// </summary>
        [Test]
        public void JsonFileDeserializer_Csv()
        {
            var xmlFileDeserializer = new JsonFileDeserializer();
            bool validationResult = xmlFileDeserializer.Validate(csv);
            
            Assert.IsFalse(validationResult);
        }
        
        /// <summary>
        /// Проверяет CSV валидитор
        /// На вход подается XML
        /// </summary>
        [Test]
        public void CsvFileDeserializer_Xml()
        {
            var fileDeserializer = new CsvFileDeserializer();
            bool validationResult = fileDeserializer.Validate(xml);
            
            Assert.IsTrue(validationResult);
        }
        
        /// <summary>
        /// Проверяет CSV валидитор
        /// На вход подается JSON
        /// </summary>
        [Test]
        public void CsvFileDeserializer_Json()
        {
            var xmlFileDeserializer = new CsvFileDeserializer();
            bool validationResult = xmlFileDeserializer.Validate(json);
            
            Assert.IsFalse(validationResult);
        }
        
        /// <summary>
        /// Проверяет CSV валидитор
        /// На вход подается CSV
        /// </summary>
        [Test]
        public void CsvFileDeserializer_Csv()
        {
            var xmlFileDeserializer = new CsvFileDeserializer();
            bool validationResult = xmlFileDeserializer.Validate(csv);
            
            Assert.IsTrue(validationResult);
        }
        
        /// <summary>
        /// Проверяет TXT валидитор
        /// На вход подается XML
        /// </summary>
        [Test]
        public void TxtFileDeserializer_Xml()
        {
            var fileDeserializer = new TxtFileDeserializer();
            bool validationResult = fileDeserializer.Validate(xml);
            
            Assert.IsTrue(validationResult);
        }
        
        /// <summary>
        /// Проверяет TXT валидитор
        /// На вход подается JSON
        /// </summary>
        [Test]
        public void TxtFileDeserializer_Json()
        {
            var xmlFileDeserializer = new TxtFileDeserializer();
            bool validationResult = xmlFileDeserializer.Validate(json);
            
            Assert.IsTrue(validationResult);
        }
        
        /// <summary>
        /// Проверяет TXT валидитор
        /// На вход подается CSV
        /// </summary>
        [Test]
        public void TxtFileDeserializer_Csv()
        {
            var xmlFileDeserializer = new TxtFileDeserializer();
            bool validationResult = xmlFileDeserializer.Validate(csv);
            
            Assert.IsTrue(validationResult);
        }
        
        /// <summary>
        /// Проверяет TXT валидитор
        /// На вход подается произвольная строка
        /// </summary>
        [Test]
        public void TxtFileDeserializer_Txt()
        {
            var xmlFileDeserializer = new TxtFileDeserializer();
            bool validationResult = xmlFileDeserializer.Validate(csv);
            
            Assert.IsTrue(validationResult);
        }
    }
}