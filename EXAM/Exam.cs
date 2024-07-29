using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal abstract class Exam
    {

        public int TimeOftheExam { get; set; }
        public int NumberOfQuestions { get; set; }
        public BaseQuestion[]? Questions { get; set; }


        public Exam(int _NumberOfQuestion) 
        {
            NumberOfQuestions = _NumberOfQuestion;
            Questions = new BaseQuestion[NumberOfQuestions];
        }

        public void AddQuestion(int index , BaseQuestion question)
        {
            if (index >= 0 && index < NumberOfQuestions)
            {
                Questions[index] = question; 
             
            }
            else
            { Console.WriteLine("Invalid index"); }
        }

       
      
        public  void ShowExam()
        {

            Console.WriteLine($"Exam Time: {TimeOftheExam}");
            Console.WriteLine($"Number of Questions: {NumberOfQuestions}");
            Console.WriteLine("Questions:");
            foreach (var question in Questions)
            {
                question.DisplayQuestion();
                Console.WriteLine();
            }
        }

        public void TakeExam()
        {
            int totalScore = 0;
            foreach (var question in Questions)
            {
                question.DisplayQuestion();
                Console.WriteLine("Please enter the answer ID:");
                int selectedAnswerId = int.Parse(Console.ReadLine());
                bool isCorrect = question.ValidateAnswer(selectedAnswerId);
                Console.WriteLine(isCorrect ? "Correct!" : "Incorrect.");
                totalScore += isCorrect ? question.Mark : 0;
            }

            Console.WriteLine($"Total Score: {totalScore}");
        }

    }

}
