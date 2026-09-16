using System;
using System.Collections.Generic;
using System.Text;

namespace Examp02
{
    class Question : ICloneable, IComparable
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }

        public Question(string header, string body, int mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public virtual void ShowQuestion()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);

            for (int i = 0; i < AnswerList.Length; i++)
            {
                Console.WriteLine(AnswerList[i]);
            }
        }

        public override string ToString()
        {
            return Header + ": " + Body + " - Mark = " + Mark;
        }

        public virtual object Clone()
        {
            Question q = new Question(Header, Body, Mark);

            q.AnswerList = AnswerList;
            q.RightAnswer = RightAnswer;

            return q;
        }

        public int CompareTo(object obj)
        {
            Question other = (Question)obj;
            return Mark.CompareTo(other.Mark);
        }
    }
}
