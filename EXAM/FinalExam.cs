using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class FinalExam : Exam
    {
        public FinalExam(int _NumberOfQuestion) : base(_NumberOfQuestion)
        {
        }

        public void ShowExam()
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


    }
 }

