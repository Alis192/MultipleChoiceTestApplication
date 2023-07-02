using Classes;
using SharedLibrary;

namespace TestPaperBuilderLibrary
{
    public class TestPaperBuilder
    {
        // Method to create a new Test Paper
        public TestPaper CreateTestPaper()
        {
            TestPaper test = new TestPaper();

            Console.WriteLine("Please add Subject Name for the test: ");
            test.SubjectName = Console.ReadLine() + "\n";
            Console.WriteLine("Subject Name: " + test.SubjectName);

            Console.WriteLine("Please enter Test Paper Name: ");
            test.TestPaperName = Console.ReadLine() + "\n";
            Console.WriteLine("Paper Name: " + test.TestPaperName);


            // Loop to create 2 questions for the test paper
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine("Question " + i);
                test.Questions.Add(CreateQuestion());
            }

            return test;
        }

        // Method to create a new Question
        private Question CreateQuestion()
        {
            Question question = new Question();

            // Request for question text
            Console.WriteLine("Please enter question: ");
            question.QuestionText = Console.ReadLine() + "\n";

            // Request for options
            Console.WriteLine("Please enter options: ");
            for (char optionLetter = 'A'; optionLetter <= 'D'; optionLetter++)
            {

                Console.WriteLine($"Option {optionLetter}: ");
                string optionText = Console.ReadLine();

                question.Options.Add(new Option { OptionLetter = optionLetter, OptionText = optionText });
            }

            // Request for the correct answer
            Console.WriteLine("Please mark the correct Option variant: A-D \n");
            char input = Console.ReadKey().KeyChar;
            InputValidator.ValidateOptionInput(ref input);
            Console.WriteLine("\n");
            question.CorrectAnswerLetter = input;

            return question;

        }



    }
}