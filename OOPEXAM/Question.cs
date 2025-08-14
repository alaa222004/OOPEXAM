using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEXAM
{
    public  abstract class Question
    {
        public string Header_of_the_question {  get; set; }
        public string Body_of_the_question { get; set; }
        public int Mark {  get; set; }
        public Answer[] answers { get; set; }
        public string RightAnsId {  get; set; }

        public Question(string head,string body,int mark, Answer[] ans,string rightans)
        {
            Header_of_the_question = head;
            Body_of_the_question = body;
            Mark=mark;
            answers=ans;
            RightAnsId = rightans;
        }
        public abstract void showquestion();

    }
}
