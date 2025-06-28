using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_c__oop_2
{
    internal class Finalexam : exam
    {
        public Finalexam(int time, int numofquestions) : base(time, numofquestions)
        {

        }

        public override void creatquestions()
        {
            listofquestions = new question[numofquestions];

            for (int i = 0; i < listofquestions.Length; i++)
            {
                int type;
                do
                {
                    Console.Write("Enter Type Of Question You Want (1 for TRUE or FALSE || 2 for MCQ ):  "); ;

                }
                while (!(int.TryParse(Console.ReadLine(), out type) && (type == 1 || type == 2)));
                Console.Clear();
                if (type == 1)
                {
                    listofquestions[i] = new TFquestions();
                    listofquestions[i].addquestion();
                    Console.Clear();
                } else if (type ==2)
                {
                    listofquestions[i]= new MCQquestions();
                    listofquestions[i].addquestion();
                    Console.Clear();
                } 
                
                


              
            }
           
        }

        public override void showexam()
        {
            int totalMarks = 0;
                int obtainedMarks = 0;
           foreach(var question in listofquestions)
            {
                Console.WriteLine(question);
               for (int i = 0; i < question.anwers.Length ; i++)
               {
                    Console.WriteLine(question.anwers[i]);
               } 
                      int answerr;
               if(question.GetType() == typeof(TFquestions)) 
                { 
                    
                do
                {
                    Console.Write("enter your answer ( 1 for TRUE || 2 for FALSE) :  "); ;

                }
                while (!(int.TryParse(Console.ReadLine(), out answerr) && (answerr == 1 || answerr == 2)));
                }
                else 
                {

                    do
                    {
                        Console.Write("enter your answer (enter  : 1 || 2 || 3) :  "); ;

                    }
                    while (!(int.TryParse(Console.ReadLine(), out answerr) && (answerr == 1 || answerr == 2|| answerr == 3)));
                }

               
                    
                question.useranswer.anwerid= answerr;
                question.useranswer.answertext= question.anwers[answerr-1].answertext;

                //Console.WriteLine($"right answer is : {question.rightanswer.answertext}");

                Console.WriteLine("=================================================================");
              if (question.useranswer.anwerid == question.rightanswer.anwerid)
                {

                    obtainedMarks += question.mark;
                }

                totalMarks += question.mark;


                

               
                
            }

            for (int i = 0; i < listofquestions.Length; i++)
            {
                Console.WriteLine($"right answer of  Q {i + 1} is : {listofquestions[i].rightanswer.answertext}");
            }

            double grade = obtainedMarks;

             Console.WriteLine($"Grade: {grade} / {totalMarks}");
                
        }
    }
}
