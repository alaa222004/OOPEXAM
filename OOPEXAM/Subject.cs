using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPEXAM
{
    public class Subject
    {
       public int Subject_Id {  get; set; }
       public string Subject_Name {  get; set; }
       public Exam Exam_of_the_subject {  get; set; }

        public Subject(int id,string name) 
        { 
            Subject_Id = id;
            Subject_Name = name;
        }

        public void create(Exam exam)
        {
            Exam_of_the_subject = exam;

        }
        public override string ToString()
        {
            return $"{Subject_Id},{Subject_Name}";
        }


    }
}
