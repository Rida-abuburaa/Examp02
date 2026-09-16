using System;
using System.Collections.Generic;
using System.Text;

namespace Examp02
{
    class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestions)
            : base(time, numberOfQuestions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine();
            Console.WriteLine("========== FINAL EXAM ==========");
            Console.WriteLine("Subject: " + Subject.SubjectName);
            Console.WriteLine("Time: " + Time + " minutes");
            Console.WriteLine("Number Of Questions: " + NumberOfQuestions);
            Console.WriteLine();

            for (int i = 0; i < Questions.Length; i++)
            {
                Console.WriteLine("Question " + (i + 1));
                Console.WriteLine("-------------------------");

                Questions[i].ShowQuestion();

                Console.WriteLine(
                    "Right Answer: " +
                    Questions[i].RightAnswer);

                Console.WriteLine("-------------------------");
            }

            Console.WriteLine("Grade is shown after the questions.");
        }
    }

}
