using System;
namespace cw2
{
    //znowu nie wiem za bardzo o co chodzilo w zadaniu
    class Program
    {
        //nie jestem zbyt kreatywna
        struct Student
        {
            public int Id;
            public string Imie;
            public string Nazwisko;
            public int NrIndeksu;
            public string RokStudiow;
        }
        struct Przedmiot
        {
            public int Id;
            public string Nazwa;
            public string Oceny;
        }
        struct Nauczyciel
        {
            public string Id;
            public string Imie;
            public string Nazwisko;
            public string Przedmiot;
            public string GodzinyZajec;
        }
        public void Main(string[] args)
        {

        }
    }
}