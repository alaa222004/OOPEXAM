using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEXAM
{
    public class MCQ : Question
    {
        public MCQ(string body, int mark, Answer[] answers, string rightAnswerId)
            : base("mcq", body, mark, answers, rightAnswerId) { }

        public override void showquestion()
        {
            Console.WriteLine($"{Header_of_the_question} :{Body_of_the_question} :{Mark} :");
            foreach (Answer answer in answers)
            {
               
                Console.WriteLine(answer);
            }
        }
    }
}
