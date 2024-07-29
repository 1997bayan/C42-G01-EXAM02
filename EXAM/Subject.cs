using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public String? SubjectName { get; set; }
        public Exam? Exam { get; set; }


        //public void CreatExam()

        //{

        //    Console.WriteLine("Please enter the Type of EXAM ( 1 for Practical | 2 for Final )");
        //    int ExamType = int.Parse(Console.ReadLine());
        //    if (ExamType == 1)
        //    {
        //        Exam = new practicalexam();
        //    }
        //    else if (ExamType == 2)
        //    {

        //        Exam = new FinalExam();
        //    }


        //    Console.WriteLine("Please Enter the time for the exam from (30 min to 180 min");
        //    int timeOFtheExam = int.Parse(Console.ReadLine());
        //    Exam.TimeOftheExam = timeOFtheExam;

        //    Console.WriteLine("Please enter the Number of the Questions :");
        //    Exam.NumberOfQuestions = int.Parse(Console.ReadLine());
        //    Console.Clear();

        public void CreateExam()
        {
            Console.WriteLine("Please enter the Type of EXAM (1 for Practical | 2 for Final):");
            int examType;
            while (!int.TryParse(Console.ReadLine(), out examType) || (examType != 1 && examType != 2))
            {
                Console.WriteLine("Invalid input. Please enter 1 for Practical or 2 for Final:");
            }

            int numberOfQuestions;
            Console.WriteLine("Please enter the number of questions:");
            while (!int.TryParse(Console.ReadLine(), out numberOfQuestions) || numberOfQuestions <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number of questions:");
            }

            if (examType == 1)
            {
                Exam = new practicalexam(numberOfQuestions);
            }
            else if (examType == 2)
            {
                Exam = new FinalExam(numberOfQuestions);
            }

            Console.WriteLine("Please enter the time for the exam in minutes (30 to 180):");
            int timeOfExam;
            while (!int.TryParse(Console.ReadLine(), out timeOfExam) || timeOfExam < 30 || timeOfExam > 180)
            {
                Console.WriteLine("Invalid input. Please enter a valid time in minutes (30 to 180):");
            }
            Exam.TimeOftheExam = timeOfExam;

            // Collect Questions
            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.WriteLine("Please enter Type Of Question (1 for MCQ | 2 for True / False)");
                int questionType = int.Parse(Console.ReadLine());
                BaseQuestion question;

                if (questionType == 1)
                {
                    question = new MCQ(3); 
                }
                else
                {
                    question = new TrueOrFalse();
                }

                question.CollectQuestionData();
                Exam.AddQuestion(i, question);
            }
        }






    }

  
    
}
