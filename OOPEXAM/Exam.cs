using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPEXAM
{
    public abstract class Exam
    {
        public int TimeOfExam { get; set; }
        public int NumOfQuestion { get; set; }
        public List<Question> Question { get; set; } = new List<Question>();
        public Exam(int time,int num)
        {
            TimeOfExam= time;
            NumOfQuestion= num;
        }
       public abstract void showexam();
    }
}
