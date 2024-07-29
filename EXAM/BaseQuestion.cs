using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace EXAM
{
    public abstract class BaseQuestion
    {
        public String? Header { get; set; }
        public String? Body { get; set; }
        public int Mark { get; set; }

        public Answer[]? AnswerList { get; set; }
        public int CorrectAnswerId { get; set; }

        //public BaseQuestion(string? header, string? body, int mark, Answer[]? answerList, int correctAnswerId)
        //{
        //    Header = header;
        //    Body = body;
        //    Mark = mark;
        //    AnswerList = answerList;
        //    CorrectAnswerId = correctAnswerId;
        //}
        //public BaseQuestion(int numberOfAnswers)
        //{
        //    AnswerList = new Answer[numberOfAnswers];
        //}

        //public void AddAnswer(int index, Answer answer)
        //{

        //    if (index >= 0 && index < AnswerList?.Length)
        //    {
        //        AnswerList[index] = answer;
        //    }

        //    else
        //    {
        //        Console.WriteLine("Invalid index");
        //    }
        //}

        public abstract void DisplayQuestion();

        public bool ValidateAnswer(int SelectedAnswerId)
        {
            return SelectedAnswerId == CorrectAnswerId;

        }

        public abstract void CollectQuestionData();


    }








 }
