using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEXAM
{
    public class Answer
    {
        public int ansId {  get; set; } 
        public string ansText {  get; set; }
        public Answer(int id,string text) 
        { 
            ansId=id;
            ansText=text;
        }
        public override string ToString()
        {
            return $"{ansId}:{ansText}";
        }
    }
}
