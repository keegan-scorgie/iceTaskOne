using System;

namespace iceTaskOne
{ 
    public class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Enter the amount of scripts to be Marked");
            int scripts2BeMarked = Convert.ToInt32(Console.ReadLine());

            while (scripts2BeMarked <= 0)
            {
                Console.WriteLine("Enter a valid amount of scripts to be Marked");
                scripts2BeMarked = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Amount of scripts captured. ");

            Console.WriteLine("Enter the amount of questions in the test");
            int numberOfQues = Convert.ToInt32(Console.ReadLine());
            while (numberOfQues < 1 || numberOfQues > 10)
            {
                Console.WriteLine("Enter a valid amount of questions in the test");
                numberOfQues = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Amount of questions captured. ");

            Console.WriteLine("Enter the subtotal of each question ");
            int subTotalOfQues = Convert.ToInt32(Console.ReadLine());
            while (subTotalOfQues < 0)
            {
                Console.WriteLine("Enter a valid subtotal for each question");
                subTotalOfQues = Convert.ToInt32(Console.ReadLine());


            }
            Console.WriteLine("Subtotal for each question captured");

            Console.WriteLine("Enter the amount of lecturers needed to mark");
            int numberOfLecturers = Convert.ToInt32(Console.ReadLine());
            while (numberOfLecturers < 0)
            {
                Console.WriteLine("Enter a vaild amount of lecturers to mark");
                numberOfLecturers = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Amount of lecturers captured ");

            int scriptsdivided = scripts2BeMarked / numberOfLecturers;
            Console.WriteLine("The amount of scripts designated to each lecturer to mark is : " + scriptsdivided);

            int timeNeededToMarkOneScipt = numberOfQues * 2;
            int timeNeededToMarkAll = timeNeededToMarkOneScipt * scripts2BeMarked;
            TimeSpan ts = TimeSpan.FromSeconds(timeNeededToMarkAll);
            
            Console.WriteLine("The time needed to mark all scripts by each designated lecturer is : " + ts);


            Console.ReadKey();
        }


    }



}


