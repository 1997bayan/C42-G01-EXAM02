using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EXAM
{
    public class MCQ : BaseQuestion

    {
        //public MCQ(string? header, string? body, int mark, Answer[]? answerList, int correctAnswerId) : base(header, body, mark, answerList, correctAnswerId)
        //{
        //}



        public MCQ(int numberOfAnswers)
        {
            AnswerList = new Answer[numberOfAnswers];
            for (int i = 0; i < AnswerList.Length; i++)
            {
                AnswerList[i] = new Answer();
            }
        }



        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header}\n{Body}");
            for (int i = 0; i < AnswerList?.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {AnswerList[i].AnswerText}");
            }
        }

        public override void CollectQuestionData()
        {
            //Console.WriteLine("Please enter Question Header:");
            //Header = Console.ReadLine();
            Header = "MCQ Question";
            Console.WriteLine(Header);


            Console.WriteLine("Please enter Question Body:");
            Body = Console.ReadLine();

            int mark;
            Console.WriteLine("Please enter the Question Mark:");
            while (!int.TryParse(Console.ReadLine(), out mark))
            {
                Console.WriteLine("Invalid input. Please enter a numeric value for the mark:");
            }
            Mark = mark;

            Console.WriteLine("Choice of Question");
            if (AnswerList is not null)
            {
                for (int i = 0; i < AnswerList.Length; i++)
                {
                    Console.WriteLine($"Please Enter Choice Number {i + 1}");
                    AnswerList[i].AnswerText = Console.ReadLine();
                    AnswerList[i].AnswerId = i + 1;
                }
            }
            int SelectedAnswerId;
            Console.WriteLine("Please enter the right of answer id:");
            while (!int.TryParse(Console.ReadLine(), out  SelectedAnswerId) ||
                   SelectedAnswerId < 1 || SelectedAnswerId > AnswerList?.Length)
            {
                Console.WriteLine($"Invalid input. Please enter a number between 1 and {AnswerList?.Length}:");

            }
            CorrectAnswerId = SelectedAnswerId;

            Console.Clear();
        }






            //public override bool ValidateAnswer(int SelectedAnswerId)
            //{
            //    return SelectedAnswerId == CorrectAnswerId ;
            //}


            //public override void CollectQuestionData()
            //{
            //    Console.WriteLine("PLease enter Question Body :");
            //    Body = Console.ReadLine();
            //    Console.WriteLine("Please enter the Question Mark");
            //    int.TryParse(Console.ReadLine(), out int mark);
            //    Mark = mark;
            //    Console.WriteLine("Choices of Questions");
            //    int n = 3;
            //    for (int i = 0; i < n; i++)
            //    {

            //        Console.WriteLine($"Please enter Choice Number {i + 1}");


            //        //Answerlist[i].AnswerText = Console.ReadLine() ;
            //        //AnswerId = i + 1;

            //    }


            //}









        }
    }

