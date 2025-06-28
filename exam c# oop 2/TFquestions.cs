using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_c__oop_2
{
    internal class TFquestions : question
    {


        public TFquestions()
        {
            header = "TRUE | FALSE Question ";

            anwers = new answer[2];
            anwers[0] = new answer(1, " true");
            anwers[1] = new answer(2, "false");
        }

        public override void addquestion()
        {
            string haeder;
            haeder = header;

            Console.WriteLine(haeder);

            string bodyy;

           
            do
            {Console.WriteLine("enter the body of the question : ");

                body = Console.ReadLine();
                 
            }
            while (!IsValidString(body));

            
            int markk;
            do
            {
                Console.WriteLine("enter the mark of the qusetion : ");
              
            }
            while (!(int.TryParse(Console.ReadLine(), out markk) && (markk > 0)));

             mark = markk ;



            

            int  idofrightanswer;
           
            do
            {
                Console.WriteLine("enter the right answer ( 1 for TRUE || 2 for False )  : ");

            }
            while (!(int.TryParse(Console.ReadLine(), out idofrightanswer) && (idofrightanswer == 1 || idofrightanswer == 2)));

             rightanswer.anwerid= idofrightanswer;
            rightanswer.answertext = anwers[idofrightanswer - 1].answertext;

        }

       
        static bool IsValidString(string text)
        {
            
            return !string.IsNullOrWhiteSpace(text);
        }

       
            

          

        
    }
}
