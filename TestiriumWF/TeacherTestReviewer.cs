using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TestStructure;

namespace TestiriumWF
{
    internal class TeacherTestReviewer
    {
        public DataTable GetDataTableResults(Test studentsTest)
        {
            DataTable studentDataTableResult = new DataTable();
            DataSet studentDataSet = new DataSet();

            studentDataSet.Tables.Add(studentDataTableResult);

            DataColumn idColumn = new DataColumn("Номер вопроса", Type.GetType("System.Int32"));
            idColumn.Unique = true;
            idColumn.AllowDBNull = false;
            idColumn.AutoIncrement = true;

            DataColumn qText = new DataColumn("Вопрос", Type.GetType("System.String"));
            DataColumn qUserAnswer = new DataColumn("Ответ обучающегося", Type.GetType("System.String"));
            DataColumn qRightAnswer = new DataColumn("Верный ответ", Type.GetType("System.String"));
            DataColumn qHasAnsweredCorrectly = new DataColumn("Обучающийся ответил верно", Type.GetType("System.String"));

            studentDataTableResult.Columns.Add(idColumn);
            studentDataTableResult.Columns.Add(qText);
            studentDataTableResult.Columns.Add(qUserAnswer);
            studentDataTableResult.Columns.Add(qRightAnswer);
            studentDataTableResult.Columns.Add(qHasAnsweredCorrectly);

            studentDataTableResult.PrimaryKey = new DataColumn[] { studentDataTableResult.Columns[0] };

            foreach (var question in studentsTest.Questions)
            {
                DataRow row = studentDataTableResult.NewRow();

                string uAnswers = question.UserAnswers.Count() > 0 ? 
                    string.Join(" | ", question.UserAnswers) :
                    "Ответа не дан";
                string rAnswers = string.Join(" | ", question.RightAnswers);

                row.ItemArray = new object[] 
                { 
                    null,
                    question.QuestionText,
                    uAnswers,
                    rAnswers, 
                    question.HasAnsweredCorrectly ? "Да" : "Нет"
                };
                studentDataTableResult.Rows.Add(row);
            }

            return studentDataTableResult;
        }

        public void ExportDataTableToXlsx(DataTable dataTable, string sheetName, 
            string fileName, int startHideColumn, int endHideColumn)
        {
            try
            {
                Stream myStream;
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "(*.xlsx)|*.xlsx";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = fileName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog.OpenFile()) != null)
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var ws = wb.Worksheets.Add(dataTable, sheetName);
                        ws.Columns().AdjustToContents();
                        ws.Columns(startHideColumn, endHideColumn).Delete();
                        wb.SaveAs(myStream);
                        myStream.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
