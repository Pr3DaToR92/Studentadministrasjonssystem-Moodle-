using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studentadministrasjonssystem__Moodle_
{
    internal class Fag
    {
        int _fagKode;
        string _fagNavn;
        double _studiePoeng;
        public Fag(int fagKode, string fagNavn, double studiePoeng)
        {
            _fagKode = fagKode;
            _fagNavn = fagNavn;
            _studiePoeng = studiePoeng;
        }
    }
}
