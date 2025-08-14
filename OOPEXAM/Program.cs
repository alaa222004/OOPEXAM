using System;

namespace OOPEXAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Subject ID: ");
            int subId = int.Parse(Console.ReadLine());

            Console.Write("Enter Subject Name: ");
            string subName = Console.ReadLine();

            Subject sub = new Subject(subId, subName);

            Console.WriteLine("enter the type of exam:(1 for practical 2 for final)");
            int examId = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the time of exam:(30 min to 180)");
            int timeexam = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the number of question:");
            int numofque = int.Parse(Console.ReadLine());

            Exam exam;
            if (examId == 1)
            
                exam = new FinalExam(timeexam, numofque);
           
            else
            
                exam = new PracticalExam(timeexam, numofque);
            
            for (int i = 0; i < numofque; i++)
            {
                Console.WriteLine("enter type of question (1 for Mcq 2 for True/False)");
                int typeques = int.Parse(Console.ReadLine());

                Console.WriteLine("enter question body :");
                string body= Console.ReadLine();

                Console.WriteLine("enter question mark:");
                int mark = int.Parse(Console.ReadLine());

                if(typeques==1)
                {
                
                    Console.WriteLine("enter the num of ans:");
                    int ans=int.Parse(Console.ReadLine());
                    Answer[] answers =new Answer [ans];

                    for(int j=0;j<ans;j++)
                    {
                        Console.WriteLine("enter answar: ");
                        string answartext=Console.ReadLine();

                        answers[j] = new Answer(ans + 1, answartext);

                    }
                    Console.WriteLine("enter right answar :");
                    string rAns=Console.ReadLine();
               
                    exam.Question.Add(new MCQ(body, mark,answers,rAns));
                }

            }
            sub.create(exam);
            sub.Exam_of_the_subject.showexam();
            
        }
    }
}
