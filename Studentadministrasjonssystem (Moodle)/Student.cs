using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem__Moodle_
{
    internal class Student
    {
        string _navn;
        int _alder;
        string _program;
        int _studentId;
        public Student(string navn, int alder, int studentId)
        {
            _navn = navn;
            _alder = alder;
            _studentId = studentId;
        }
    }
}
