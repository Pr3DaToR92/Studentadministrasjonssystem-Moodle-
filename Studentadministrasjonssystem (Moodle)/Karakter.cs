using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem__Moodle_
{
    internal class Karakter
    {
        int _karakterVerdi;
        Student _karakterStudent;
        string _karakterFag;
        public Karakter(int karakterVerdi, string navn, int alder, int studentId)
        {
            _karakterVerdi = karakterVerdi;
            _karakterStudent = new Student(navn, alder, studentId);
            //_karakterStudent = karakterStudent;
            //_karakterFag = karakterFag;
        }
        
    }
}
