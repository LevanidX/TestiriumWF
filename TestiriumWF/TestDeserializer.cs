using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using TestStructure;

namespace TestiriumWF
{
    internal class TestDeserializer
    {
        MySqlWriter mySqlWriter = new MySqlWriter();

        private Test _studentsTest = new Test();
        List<Question> questionsList = new List<Question>();

        private string _xmlTestFile;

        public TestDeserializer(Test studentTest, string xmlTestFile)
        {
            _studentsTest = studentTest;
            _xmlTestFile = xmlTestFile;
        }

        public Test DeserializeTest()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Test));

            using (var stringReader = new StringReader(_xmlTestFile))
            {
                var test = (Test)xmlSerializer.Deserialize(stringReader);

                return test;
            }
        }
    }
}
