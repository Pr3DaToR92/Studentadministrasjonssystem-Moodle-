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
        string _karakterStudent;
        string _karakterFag;
        public Karakter(int karakterVerdi, string karakterStudent, string karakterFag)
        {
            _karakterVerdi = karakterVerdi;
            _karakterStudent = karakterStudent;
            _karakterFag = karakterFag;
        }
        public void getKarakterInfo()
        {
            var karakter1 = new Karakter( 1,  "Peter Parker",  "NK");

        }
    }
}
