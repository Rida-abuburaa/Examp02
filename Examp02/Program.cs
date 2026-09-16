namespace Examp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("       EXAM MANAGEMENT SYSTEM");
            Console.WriteLine("=================================");
            Console.WriteLine();

            // =========================
            // Subject Information
            // =========================

            Console.Write("Enter Subject ID: ");
            int subjectId = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject Name: ");
            string subjectName = Console.ReadLine();

            Subject subject = new Subject(
                subjectId,
                subjectName);

            // =========================
            // Exam Information
            // =========================

            Console.WriteLine();
            Console.WriteLine("Select Exam Type:");
            Console.WriteLine("1 - Final Exam");
            Console.WriteLine("2 - Practical Exam");

            Console.Write("Enter choice: ");
            int examType = int.Parse(Console.ReadLine());

            Console.Write("Enter Exam Time (minutes): ");
            int time = int.Parse(Console.ReadLine());

            Console.Write("Enter Number Of Questions: ");
            int numberOfQuestions = int.Parse(Console.ReadLine());

            Exam exam;

            if (examType == 1)
            {
                exam = new FinalExam(
                    time,
                    numberOfQuestions);
            }
            else
            {
                exam = new PracticalExam(
                    time,
                    numberOfQuestions);
            }

            // =========================
            // Enter Questions
            // =========================

            for (int i = 0; i < numberOfQuestions; i++)
            {
                Console.WriteLine();
                Console.WriteLine("==============================");
                Console.WriteLine("Question " + (i + 1));
                Console.WriteLine("==============================");

                Console.WriteLine("Select Question Type:");
                Console.WriteLine("1 - True / False");
                Console.WriteLine("2 - MCQ");

                Console.Write("Enter choice: ");
                int questionType = int.Parse(Console.ReadLine());

                Console.Write("Enter Question Header: ");
                string header = Console.ReadLine();

                Console.Write("Enter Question Body: ");
                string body = Console.ReadLine();

                Console.Write("Enter Question Mark: ");
                int mark = int.Parse(Console.ReadLine());

                // =========================
                // True / False
                // =========================

                if (questionType == 1)
                {
                    TrueFalseQuestion question =
                        new TrueFalseQuestion(
                            header,
                            body,
                            mark);

                    Console.WriteLine();
                    Console.WriteLine("Choose Right Answer:");
                    Console.WriteLine("1 - True");
                    Console.WriteLine("2 - False");

                    Console.Write("Enter correct answer: ");
                    int correctAnswer =
                        int.Parse(Console.ReadLine());

                    question.RightAnswer =
                        question.AnswerList[correctAnswer - 1];

                    exam.Questions[i] = question;
                }

                // =========================
                // MCQ
                // =========================

                else if (questionType == 2)
                {
                    Answer[] answers = new Answer[4];

                    Console.WriteLine();
                    Console.WriteLine("Enter 4 Answers:");

                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(
                            "Answer " + (j + 1) + ": ");

                        string answerText =
                            Console.ReadLine();

                        answers[j] =
                            new Answer(
                                j + 1,
                                answerText);
                    }

                    Console.WriteLine();
                    Console.Write("Enter correct answer number (1-4): ");

                    int correctAnswer =
                        int.Parse(Console.ReadLine());

                    MCQQuestion question =
                        new MCQQuestion(
                            header,
                            body,
                            mark,
                            answers);

                    question.RightAnswer =
                        answers[correctAnswer - 1];

                    exam.Questions[i] = question;
                }
            }

            // =========================
            // Create Exam
            // =========================

            subject.CreateExam(exam);

            // =========================
            // Show Exam
            // =========================

            Console.Clear();

            subject.Exam.ShowExam();

            Console.WriteLine();
            Console.WriteLine("Press Enter to start the exam...");
            Console.ReadLine();

            Console.Clear();

            int grade = subject.Exam.SolveExam();

            Console.WriteLine();
            Console.WriteLine("=================================");
            Console.WriteLine("           EXAM RESULT");
            Console.WriteLine("=================================");
            Console.WriteLine("Your Grade: " + grade);

            Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }


}
