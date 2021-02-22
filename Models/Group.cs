using System;
using System.Collections.Generic;
using System.Text;

namespace AP8PO
{
    //Studijní obor
    public class Group
    {
        string Abbrevation { get; set; }                //Zkratka oboru
        int Year { get; set; }
        Semester Semester { get; set; }
        int NumberOfStudents { get; set; }
        StudyForm studyForm { get; set; }
        StudyType StudyType { get; set; }
        Language Language { get; set; }


    }
}
