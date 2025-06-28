using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_c__oop_2
{
    internal class MCQquestions : question
    {

        public MCQquestions()
        {
            header = "MCQ Question ";

            anwers = new answer[3];
           
        }

        public override void addquestion()
        {


            string haeder;
            haeder = header;

            Console.WriteLine(haeder);

            string bodyy;


            do
            {
                Console.WriteLine("enter the body of the question : ");

               body  = Console.ReadLine();
                 
                
            }
            while (!IsValidString(body));

            int markk;
            do
            {
                Console.WriteLine("enter the mark of the qusetion : ");


            }
            while (!(int.TryParse(Console.ReadLine(), out markk ) && (markk > 0)));

              mark = markk ;

            Console.WriteLine("choice of the question : ");

            for (int i = 0; i < anwers.Length; i++)
            {

                anwers[i]=  new answer() { anwerid = i+1 };

                string choice;


                do
                {
                    Console.Write($"enter choice  {i+1} : ");

                    anwers[i].answertext = Console.ReadLine();
                    
                }
                while (!(IsValidString(anwers[i].answertext)));


            }

            int idofrightanswer;

            do
            {
                Console.WriteLine("enter the right anwer of the question (enter the number of choice): ");

            }
            while (!(int.TryParse(Console.ReadLine(), out idofrightanswer) && (idofrightanswer == 1 || idofrightanswer == 2 || idofrightanswer==3)));

            rightanswer.anwerid = idofrightanswer;
            rightanswer.answertext = anwers[idofrightanswer - 1].answertext;


            
            Console.Clear();
        }

        

        static bool IsValidString(string text)
        {

            return !string.IsNullOrWhiteSpace(text);
        }

    }
}
