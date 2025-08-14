using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEXAM
{
    //Practical Exam Shows the right answer after finishing the Exam.
    public class PracticalExam:Exam
    {
        public PracticalExam (int time, int numofq):base(time, numofq) { }
     
        public override void showexam()
        {
            Console.WriteLine($"Time Of Exam= {TimeOfExam}");
            foreach(var Q in Question)
            {
                Q.showquestion();
                Console.WriteLine($"right answar :{Q.RightAnsId}");
            }


        }
    }
}
