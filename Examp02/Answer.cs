using System;
using System.Collections.Generic;
using System.Text;

namespace Examp02
{
    class Answer : ICloneable, IComparable
    {
        public int AnswerId { get; set; }
        public string AnswerText { get; set; }

        public Answer(int id, string text)
        {
            AnswerId = id;
            AnswerText = text;
        }

        public override string ToString()
        {
            return AnswerId + " - " + AnswerText;
        }

        public object Clone()
        {
            return new Answer(AnswerId, AnswerText);
        }

        public int CompareTo(object obj)
        {
            Answer other = (Answer)obj;
            return AnswerId.CompareTo(other.AnswerId);
        }
    }


}
