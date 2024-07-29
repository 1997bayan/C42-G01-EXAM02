namespace EXAM
{





    internal class Program
    {
        static void Main(string[] args)

        {

            Subject subject = new Subject ();
            //{
            //    SubjectId = 1,
            //    SubjectName = "Mathematics"
            //};

            Console.WriteLine("please enter Subject Name");
            subject.SubjectName = Console.ReadLine();

            subject.CreateExam();

            Console.WriteLine($"Subject: {subject.SubjectName}");
            Console.WriteLine($"Exam Type: {(subject.Exam is practicalexam ? "Practical" : "Final")}");
            Console.WriteLine($"Do You Want To Start Exam (Y/N)");
            string startExam = Console.ReadLine();

            if (startExam.ToUpper() == "Y")
            {
                subject.Exam.TakeExam();
            }

            Console.WriteLine("Thank you for taking the exam.");
        }
        //Subject subject = new Subject();

        //subject.CreatExam();

        //bool flag = true;
        //int TypeOFQuestion;
        //do
        //{
        //    Console.WriteLine("Please enter type of Question (1 for MCQ | 2 for True | False ");
        //    int.TryParse(Console.ReadLine(), out TypeOFQuestion);

        //} while (!flag);

        //if (TypeOFQuestion == 1 )
        //{
        //    MCQ mcqQ = new MCQ();
        //    Console.WriteLine("MCQ Questuin :");
        //    mcqQ.colletQuestionData();
        //    Console.WriteLine("Please Enter the right answe id:");

        //    int SelectedAnswerId;
        //    int.TryParse(Console.ReadLine(), out SelectedAnswerId);
        //    mcqQ.ValidateAnswer(SelectedAnswerId);


        //}



    
    }
}
