using System.Configuration;

namespace TestStructure
{
    internal class TestTypes
    {
        public static string OneAnswerQuestion = 
            ConfigurationManager.AppSettings.Get("OneAnswerQuestion");
        public static string MultipleAnswerQuestion =
            ConfigurationManager.AppSettings.Get("MultipleAnswerQuestion");
        public static string TextAnswerQuestion =
            ConfigurationManager.AppSettings.Get("TextAnswerQuestion");
        public static string SequenceAnswerQuestion =
            ConfigurationManager.AppSettings.Get("SequenceAnswerQuestion");
        public static string MatchAnswerQuestion =
            ConfigurationManager.AppSettings.Get("MatchAnswerQuestion");
    }
}
