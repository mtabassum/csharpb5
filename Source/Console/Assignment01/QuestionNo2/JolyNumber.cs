using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionNo2
{
    public class JolyNumber
    {
        protected int number;
        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
            }
        }

        public JolyNumber()
        {
            number = 0;
        }

        public JolyNumber(int a)
        {
            number = a;
        }

        public virtual void Increment()
        {
            number++;
        }
        public void Increment(int n1)
        {
            number += n1;
        }
    }

    public class MolyNumber : JolyNumber
    {
        public override void Increment()
        {
            number = number + 1;
        }
    }

}

