using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEXAM
{
    public class FinalExam : Exam
    {
        public FinalExam(int time, int num) : base(time, num)
        {
        }

        public override void showexam()
        {
            int totalmark = 0, graed = 0;

            Console.WriteLine();
            foreach (var Q in Question)
            {
                Q.showquestion();
                Console.WriteLine("Answar is : ");
                string ans = Console.ReadLine();
                if (ans == Q.RightAnsId)
                    totalmark += Q.Mark;

            }
            Console.WriteLine($"Gread={graed}/{totalmark}");
        }
    }
}
