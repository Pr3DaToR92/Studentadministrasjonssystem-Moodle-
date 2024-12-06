using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem__Moodle_
{
    internal class Skole
    {
        private Student _student;
        private Karakter _karakter;
        private Fag _fag;

        public Skole()
        {
            _student = new Student();
            _karakter = new Karakter();
            _fag = new Fag();
        }
    }
}
