using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public String? AnswerText { get; set; }
        public Answer(int answerId, string? answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public Answer() { }


        public override string ToString()
        {
            return $"AnswerId : {AnswerId} : {AnswerText}";
        }
    }
}
