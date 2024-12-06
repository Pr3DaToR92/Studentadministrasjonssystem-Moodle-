// See https://aka.ms/new-console-template for more information

using Studentadministrasjonssystem__Moodle_;
void Run()
{
    Run();
}

//Studenter
Student student1 = new Student("Per Olaf Jatteson", 19, 1);
Student student2 = new Student("Jarvald Trygg Sørenson", 18,2);
Student student3 = new Student("Mark Morton", 21,3);

//Fag
Fag fag1 = new Fag(1,"Nøkkelkompetanse",12);
Fag fag2 = new Fag(2, "Mattematikk", 33);
Fag fag3 = new Fag(3, "Samfunnsfag", 45);

//Karakter
Karakter karakter1 = new Karakter(6, student1, fag2);