using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class TrueOrFalse : BaseQuestion
    {
        public override void CollectQuestionData()
        {
            Header = "True | False Question";
            Console.WriteLine("Please enter Question Body:");
            Body = Console.ReadLine();

            int mark;
            Console.WriteLine("Please enter the Question Mark:");
            while (!int.TryParse(Console.ReadLine(), out mark))
            {
                Console.WriteLine("Invalid input. Please enter a numeric value for the mark:");
            }
            Mark = mark;

            int SelectedAnswerId;
            Console.WriteLine("Please enter the Riht answer ID [1 FOR True] [2 For Fasle]");
            while (!int.TryParse(Console.ReadLine(), out  SelectedAnswerId) ||
                  SelectedAnswerId < 1 || SelectedAnswerId > 2)
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2:");
            }

            CorrectAnswerId = SelectedAnswerId;

            
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Body} \n 1-True \n 2-False"); 
        }

        public override string ToString()
        {
            return $"{Header}\n{Body}\nMark: {Mark}\n1. {AnswerList[0]}\n2. {AnswerList[1]}";
        }


    }
}
