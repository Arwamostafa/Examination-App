using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_c__oop_2
{
    internal class answer
    {
        public answer(int anwerid, string answertext)
        {
            this.anwerid = anwerid;
            this.answertext = answertext;
        }

        public int anwerid  { get; set; }

        public string answertext  { get; set; }

        public answer() { }

        public override string ToString()
        {
            return $" choice  {anwerid} : { answertext } ";
        }
    }
}
