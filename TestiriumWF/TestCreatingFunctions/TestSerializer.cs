using System.IO;
using System.Xml.Serialization;
using TestStructure;

namespace TestiriumWF.TestCreatingFunctions
{
    internal class TestSerializer
    {
        /// <summary>
        /// Сериализует тестирование в XML-файл
        /// </summary>
        /// <param name="studentsTest">Тестирование</param>
        /// <returns>XML-файл</returns>
        public string SerializeTestIntoXml(Test studentsTest)
        {
            var xmlSerializer = new XmlSerializer(typeof(Test));
            var testWriter = new StringWriter();

            xmlSerializer.Serialize(testWriter, studentsTest, ClearNamespaces());

            return testWriter.ToString();
        }

        /// <summary>
        /// Удаление пространства имен в начале файла XML
        /// </summary>
        /// <returns>Пространство имен</returns>
        private XmlSerializerNamespaces ClearNamespaces()
        {
            var xmlNamespace = new XmlSerializerNamespaces();
            xmlNamespace.Add(string.Empty, string.Empty);
            return xmlNamespace;
        }
    }
}
