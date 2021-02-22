using System;
using System.Collections.Generic;
using System.Text;

namespace AP8PO
{
    public class Subject
    {
        string Abbrevation { get; set; }                //Zkratka předmětu
        int Weeks { get; set; }
        int LectureHours { get; set; }
        int ExerciseHours { get; set; }
        int SemminarHours { get; set; }
        CourseCompletionType CourseCompletionType { get; set; }
        Language Language { get; set; }
        int SizeOfGroup { get; set; }

        

       
    }
}
