using MySql.Data.MySqlClient;
using System.IO;
using System.Xml.Serialization;
using TestiriumWF.SqlFunctions;
using TestStructure;

namespace TestiriumWF
{
    internal class TestDeserializer
    {
        private MySqlFunctions _mySqlFunctions = new MySqlFunctions();

        public Test GetDeserializedTest(int studentsTestNumber)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Test));

            var xmlFile = _mySqlFunctions.CallProcedureWithReturnedDataTable("get_test_file", new MySqlParameter[]
            {
                new MySqlParameter("user_id", UserConfig.UserId),
                new MySqlParameter("test_num", studentsTestNumber)
            }).Rows[0][0].ToString();

            return (Test)xmlSerializer.Deserialize(new StringReader(xmlFile));
        }
    }
}
