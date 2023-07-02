using Classes;
using System.Runtime.Serialization;
using TestPaperBuilderLibrary;
using TestTakerLibrary;

namespace MCQApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a test paper
            TestPaperBuilder testBuilder = new TestPaperBuilder();
            TestPaper testPaper = testBuilder.CreateTestPaper();


            // Taking the test
            Console.WriteLine("Now you are a student");
            TestTakerClass testTaker = new TestTakerClass();
            testTaker.TakeTest(testPaper);
        }
    }
}