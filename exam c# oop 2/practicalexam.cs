using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_c__oop_2
{
    internal class practicalexam : exam
    {
        public practicalexam(int time, int numofquestions) : base(time, numofquestions)
        {
        }

        public override void creatquestions()
        {
            listofquestions = new question[numofquestions];

            for (int i = 0; i < listofquestions.Length; i++)
            {

                listofquestions[i] = new MCQquestions();
                listofquestions[i].addquestion();


            }

        }

        public override void showexam()
        {
           foreach (var question in listofquestions)
            {
                Console.WriteLine(question);

                for (int i = 0; i < question.anwers.Length; i++)
                {
                    Console.WriteLine(question.anwers[i]);

                }
                int useranswer;

                do
                {
                    Console.Write("enter your answer (enter  :  1 || 2 || 3) :  "); ;

                }
                while (!(int.TryParse(Console.ReadLine(), out useranswer) && (useranswer == 1 || useranswer == 2 || useranswer == 3)));

                question.useranswer.anwerid= useranswer;
                question.useranswer.answertext = question.anwers[useranswer-1].answertext;

                //Console.WriteLine($"right answer is : {question.rightanswer.answertext}");

                Console.WriteLine("=================================================================");
            }
           

            for (int i = 0; i < listofquestions.Length; i++)
            {
                 Console.WriteLine($"right answer of  Q {i+1} is : {listofquestions[i].rightanswer.answertext}");
            }
                

        }
    }
}
