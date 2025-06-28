using System.Diagnostics;

namespace exam_c__oop_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            subject sub1 = new subject(10, "c#");
            sub1.craetexam();
            Console.Clear();
            Console.Write("Do you want to start the exam (y | n): ");

            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                sub1.typeofexam.showexam();
                sw.Stop();
                Console.WriteLine($"The Elapsed Time= {sw.Elapsed}");
            }
            else
            {
                Console.WriteLine(" exam is  blocked");
            }
        }
    }
}
