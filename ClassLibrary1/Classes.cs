using Interfaces;

namespace Classes
{
    public class TestPaper : ITestPaper
    {
        public string SubjectName { get; set; }
        public string TestPaperName { get; set; }
        public List<IQuestion> Questions { get; set; }

        public TestPaper()
        {
            Questions = new List<IQuestion>();
        }
    }


    public class Question : IQuestion
    {
        public string QuestionText { get; set; }
        public List<IOption> Options { get; set; }
        public char CorrectAnswerLetter { get; set; }
        public char OptionSelectedByStudent { get; set; }
        public int Score { get; set; }


        public Question()
        {
            Options = new List<IOption>();
            Score = 0;
        }
    }


    public class Option : IOption
    {
        public char? OptionLetter { get; set; }
        public string? OptionText { get; set; }

    }


    public class Student : IStudent
    {
        public int RollNo { get; set; }
        public string StudentName { get; set; }
        public List<ITestPaper> TestPapers { get; set; }

        public Student()
        {
            TestPapers = new List<ITestPaper>();
        }
    }
}