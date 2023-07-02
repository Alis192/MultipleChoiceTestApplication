using Classes;
using Interfaces;
using SharedLibrary;

namespace TestTakerLibrary
{
    public class TestTakerClass
    {
        // Method to simulate taking a test
        public void TakeTest(TestPaper testPaper)
        {
            int questionNo = 0;
            Student student = new Student();

            // Request for student roll number and name
            Console.WriteLine("Please enter Student Roll No: ");
            string inputString = Console.ReadLine();
            int input;

            while (!Int32.TryParse(inputString, out input) || string.IsNullOrEmpty(inputString))
            {
                Console.WriteLine("Roll Number should only contain numbers and shouldn't left blank!\n");
                inputString = Console.ReadLine();
            }

            student.RollNo = input;

            Console.WriteLine("Please enter Student Name: ");
            student.StudentName = Console.ReadLine();

            Console.WriteLine("Please answer questions. \n");


            // Loop to ask each question
            foreach (var question in testPaper.Questions)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Question no " + (questionNo + 1) + "\n");
                Console.WriteLine(question.QuestionText);

                foreach (IOption option in question.Options)
                {
                    Console.WriteLine(option.OptionLetter + ") " + option.OptionText + "\n");
                }


                // Request for the answer
                Console.Write("Select your answer from A to D: ")
                char inputChecker = Console.ReadKey().KeyChar;
                InputValidator.ValidateOptionInput(ref inputChecker);
                question.OptionSelectedByStudent = inputChecker;

                // Checking the answer and assigning score
                if (question.OptionSelectedByStudent == question.CorrectAnswerLetter)
                {
                    question.Score = 1;
                }
                else
                {
                    question.Score = 0;
                }
                questionNo++;
            }


            // Calculating overall score and outputting result
            double sum = testPaper.Questions.Sum(question => question.Score);
            double overallScore = ((sum) / Convert.ToDouble(questionNo)) * 100;
            Console.WriteLine("\n");
            Console.WriteLine("Correct answers: " + sum);
            Console.WriteLine($"Your score: {overallScore}% ");
        }

    }
}