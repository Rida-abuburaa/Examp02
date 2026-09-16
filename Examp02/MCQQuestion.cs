using System;
using System.Collections.Generic;
using System.Text;

namespace Examp02
{
    class MCQQuestion : Question
    {
        public MCQQuestion(
            string header,
            string body,
            int mark,
            Answer[] answers)
            : base(header, body, mark)
        {
            AnswerList = answers;
        }

        public override void ShowQuestion()
        {
            base.ShowQuestion();
        }
    }
}
