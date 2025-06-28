using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_c__oop_2
{
    internal abstract class  question
    {
        public string header { get; set; }

        public string body { get; set; }

        public int mark { get; set; }

        public  answer[] anwers  { get; set; }

        public answer rightanswer { get; set; }
        public answer useranswer { get; set; }

        public question()
        {
            rightanswer = new answer();
            useranswer = new answer();
        }

        public abstract void addquestion();

        public override string ToString()
        {
            return $"question : {header}  \n *  {body}     ( mark {mark}) ";
        }
    }
}
