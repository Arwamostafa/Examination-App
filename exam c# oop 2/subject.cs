using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_c__oop_2
{
    internal class subject
    {
        public subject(int id, string name)
        {
            this.id = id;
            this.name = name;
            
        }

        public int id { get; set; }
        public string name { get; set; }

        public exam typeofexam { get; set; }

       public  void craetexam()
        {

            int exam;
            int time;
            int num;
            do
            {
                Console.Write("Enter type of exam you want ( 1 for FINAL || 2 for PRACTICAL )  :  "); ;

            }
            while (!(int.TryParse(Console.ReadLine(), out exam) && (exam == 1 || exam == 2)));

            do
            {
                Console.Write("Enter time of exam in minutes  :  "); 

            }
            while (!(int.TryParse(Console.ReadLine(), out time) && (time > 0)));

            do
            {
                Console.Write("Enter number of question you want  :  ");

            }
            while (!(int.TryParse(Console.ReadLine(), out num) && (num > 0)));
             Console.Clear();

            if (exam == 1)
            {
                typeofexam = new Finalexam(time,num);
                typeofexam.creatquestions();
            }
            else
            {
                typeofexam = new practicalexam(time,num);
                typeofexam.creatquestions();
            }

           
        }
    }
    
}
