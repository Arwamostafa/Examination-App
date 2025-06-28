using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_c__oop_2
{
    internal abstract class exam
    {
        protected exam (int time, int numofquestions)
        {
            this.time = time;
            this.numofquestions = numofquestions;
           
        }

        public int time { get; set; }

        public int numofquestions { get; set; }

        public question[] listofquestions { get; set;}

        public abstract void creatquestions();

        public abstract void showexam();
    }
}
