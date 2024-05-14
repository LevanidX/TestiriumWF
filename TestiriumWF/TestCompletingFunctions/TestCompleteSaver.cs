using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestiriumWF.SqlFunctions;
using TestiriumWF.TestCreatingFunctions;
using TestStructure;

namespace TestiriumWF.TestCompletingFunctions
{
    internal class TestCompleteSaver
    {
        private MySqlFunctions _mySqlFunctions = new MySqlFunctions();
        private TestSerializer _testSerializer = new TestSerializer();

        public void SaveTestInDatabase(int studentsTestNumber, Test studentsTest, int tryNumber)
        {
            _mySqlFunctions.CallProcedure("push_new_completed_test", new MySqlParameter[]
            {
                new MySqlParameter("test_id", studentsTestNumber),
                new MySqlParameter("user_id", UserConfig.UserId),
                new MySqlParameter("test_file", _testSerializer.SerializeTestIntoXml(studentsTest)),
                new MySqlParameter("mark_value", studentsTest.OverallResult.OverallMarkScore),
                new MySqlParameter("percentage_value", studentsTest.OverallResult.OverallPercentageScore),
                new MySqlParameter("try_number", tryNumber)
            });
        }
    }
}
