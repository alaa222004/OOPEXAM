using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEXAM
{
    public class TrueOrFalse : Question
    {
        public TrueOrFalse(string body, int mark, string rightAnswerId)
            : base("true , false ", body, mark, new Answer[] {new Answer(1,"true"),new Answer (2,"false")}, rightAnswerId) { }

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
