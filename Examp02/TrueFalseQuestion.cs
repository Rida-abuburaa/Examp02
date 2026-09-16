using System;
using System.Collections.Generic;
using System.Text;

namespace Examp02
{
  
        class TrueFalseQuestion : Question
        {
            public TrueFalseQuestion(
                string header,
                string body,
                int mark)
                : base(header, body, mark)
            {
                AnswerList = new Answer[2];

                AnswerList[0] = new Answer(1, "True");
                AnswerList[1] = new Answer(2, "False");
            }

            public override void ShowQuestion()
            {
                base.ShowQuestion();
            }
        }
    }

    

