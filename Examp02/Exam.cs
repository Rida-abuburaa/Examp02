using System;
using System.Collections.Generic;
using System.Text;

namespace Examp02
{

    abstract class Exam
    {
        public int Time { get; set; }
        public int NumberOfQuestions { get; set; }

        public Question[] Questions { get; set; }

        public Subject Subject { get; set; }

        public Exam(int time, int numberOfQuestions)
        {
            Time = time;
            NumberOfQuestions = numberOfQuestions;
            Questions = new Question[numberOfQuestions];
        }

        public abstract void ShowExam();

        public int SolveExam()
        {
            int grade = 0;

            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("          SOLVE EXAM");
            Console.WriteLine("=================================");
            Console.WriteLine();

            for (int i = 0; i < Questions.Length; i++)
            {
                Question question = Questions[i];

                Console.WriteLine("Question " + (i + 1));
                Console.WriteLine("-------------------------");

                Console.WriteLine(question.Header);
                Console.WriteLine(question.Body);

                // Show answers
                for (int j = 0; j < question.AnswerList.Length; j++)
                {
                    Console.WriteLine(question.AnswerList[j]);
                }

                Console.WriteLine();

                // Student answer
                Console.Write("Enter your answer: ");
                int studentAnswer = int.Parse(Console.ReadLine());

                // Check answer
                if (studentAnswer == question.RightAnswer.AnswerId)
                {
                    grade += question.Mark;
                }

                Console.WriteLine();
            }

            return grade;
        }
    }

}
