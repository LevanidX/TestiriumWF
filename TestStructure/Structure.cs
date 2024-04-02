using System.Collections.Generic;
using System.Xml.Serialization;

namespace TestStructure
{
    [XmlRoot("Test")]
    public class Test
    {
        [XmlAttribute] public string Name;
        public Description Description;
        public List<Question> Questions;
        public TestSettings TestSettings;
    }

    public class Description
    {
        [XmlAttribute] public string Text;
        [XmlArrayItem(ElementName = "DescriptionImageNumber")] public List<int> DescriptionImages;

        public Description() { }

        public Description(string text, List<int> descriptionImages)
        {
            Text = text;
            DescriptionImages = descriptionImages;
        }

        public Description(string text) 
        { 
            Text = text; 
        }
    }

    public class Question
    {
        [XmlAttribute] public string QuestionType;
        public string QuestionText;
        [XmlArrayItem(ElementName = "AnswerText")] public List<string> Answers;
        [XmlArrayItem(ElementName = "RightAnswerText")] public List<string> RightAnswers;
        [XmlArrayItem(ElementName = "QuestionImageNumber")] public List<int> QuestionImages;
        public QuestionSettings QuestionSettings;

        public Question() { }

        /// <summary>
        /// Конструктор вопросов без параметра изображений
        /// </summary>
        /// <param name="type"></param>
        /// <param name="questionText"></param>
        /// <param name="answers"></param>
        /// <param name="rightAnswers"></param>
        public Question(string type, string questionText, List<string> answers,
            List<string> rightAnswers, QuestionSettings questionSettings)
        {
            QuestionType = type;
            QuestionText = questionText;
            Answers = answers;
            RightAnswers = rightAnswers;
            QuestionSettings = questionSettings;
        }

        /// <summary>
        /// Конструктор вопросов с параметром изображений
        /// </summary>
        /// <param name="questionType"></param>
        /// <param name="questionText"></param>
        /// <param name="answers"></param>
        /// <param name="rightAnswers"></param>
        /// <param name="questionImages"></param>
        public Question(string questionType, string questionText, List<string> answers,
            List<string> rightAnswers, List<int> questionImages)
        {
            QuestionType = questionType;
            QuestionText = questionText;
            Answers = answers;
            RightAnswers = rightAnswers;
            QuestionImages = questionImages;
        }
    }

    public class QuestionSettings
    {
        public bool IsCaseSensitivityOn;

        public QuestionSettings() { }

        public QuestionSettings(bool isCaseSensitivityOn)
        {
            IsCaseSensitivityOn = isCaseSensitivityOn;
        }
    }

    public class TestSettings
    {
        public EstimationMethods EstimationMethod;
        public TimeLimitedTest TimeLimitedTest;
        public TestPassword TestPassword;

        public TestSettings() { }

        public TestSettings(EstimationMethods estimationMethods, TimeLimitedTest timeLimitedTest, TestPassword testPassword)
        {
            EstimationMethod = estimationMethods;
            TimeLimitedTest = timeLimitedTest;
            TestPassword = testPassword;
        }
    }

    public class EstimationMethods
    {
        [XmlAttribute] public string Type;
        public EstimationParametres EstimationParametres;

        public EstimationMethods() { }

        public EstimationMethods(string type, EstimationParametres estimationParametres)
        {
            Type = type;
            EstimationParametres = estimationParametres;
        }
    }

    public class EstimationParametres
    {
        public int BadMarkPercentage;
        public int SatisfactoryMarkPercentage;
        public int NormalMarkPercentage;
        public int ExcellentMarkPercentage;
        public int PassMarkPercentage;

        public EstimationParametres() { }

        public EstimationParametres(int passMarkPercentage)
        {
            PassMarkPercentage = passMarkPercentage;
        }

        public EstimationParametres(int badMarkPercentage, int satisfactoryMarkPercentage,
            int normalMarkPercentage, int excellentMarkPercentage)
        {
            BadMarkPercentage = badMarkPercentage;
            SatisfactoryMarkPercentage = satisfactoryMarkPercentage;
            NormalMarkPercentage = normalMarkPercentage;
            ExcellentMarkPercentage = excellentMarkPercentage;
        }
    }

    public class TimeLimitedTest
    {
        [XmlAttribute] public bool Value;
        public int TimeLimit;

        public TimeLimitedTest() { }

        public TimeLimitedTest(bool value, int timeLimit)
        {
            Value = value;
            TimeLimit = timeLimit;
        }
    }

    public class TestPassword
    {
        [XmlAttribute] public bool Value;
        public string Password;

        public TestPassword() { }

        public TestPassword(bool value, string password)
        {
            Value = value;
            Password = password;
        }
    }
}
