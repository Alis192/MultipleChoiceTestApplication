using Microsoft.VisualBasic.FileIO;

namespace Interfaces
{
    public interface ITestPaper
    {
        string SubjectName { get; set; }
        string TestPaperName { get; set; }
        List<IQuestion> Questions { get; set; }
    }


    public interface IQuestion 
    {
        string QuestionText { get; set; }
        List<IOption> Options { get; set; }
        char CorrectAnswerLetter { get; set; }
        char OptionSelectedByStudent { get; set; }
        int Score { get; set; }
    }

    public interface IStudent
    {
        int RollNo { get; set; }
        string StudentName { get; set; }
        List<ITestPaper> TestPapers { get; set; }
    }


    public interface IOption
    {
        char? OptionLetter { get; set; }
        string? OptionText { get; set; }
    }
}