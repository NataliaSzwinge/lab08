using System;
namespace cw4
{
    //nie rozumiem o co chodzi, nie wiem jak to rozwiazac
    enum PlecStudenta
    {
        Kobieta,
        Mezczyzna
    }
    struct Student
    {
        public string Nazwisko;
        public int NrAlbumu;
        public float Ocena;
        public PlecStudenta Plec;
    }
    class Program
    {
        
        static void Main()
        {
            Student[] studenci = new Student[5];
            Wypelnianie(ref studenci[0], "Kowalski", 1234, 6.0f, PlecStudenta.Mezczyzna);
            Wypelnianie(ref studenci[1], "Kowalska", 1345, 5.0f, PlecStudenta.Kobieta);
            Wypelnianie(ref studenci[2], "Nowakowska", 1456, 4.0f, PlecStudenta.Kobieta);
            Wypelnianie(ref studenci[3], "Mazur", 1567, 2.0f, PlecStudenta.Kobieta);
            Wypelnianie(ref studenci[4], "Nowak", 1678, 1.0f, PlecStudenta.Mezczyzna);
            foreach (Student student in studenci)
            {
                Wyswietlanie(student);
            }
            float srednia = WyliczSrednia(studenci);
            Console.WriteLine("Srednia" + srednia);
        }
        static void Wypelnianie(ref Student Wypelnij, string Nazwisko, int NrAlbumu, float Ocena, PlecStudenta Plec)
        {
            Wypelnij.Nazwisko = Nazwisko;
            Wypelnij.NrAlbumu = NrAlbumu;
            Wypelnij.Plec = Plec;
            if(Ocena < 2.00f)
            {
                Student.Ocena = 2.00f;
            }
            else if(Ocena > 5.00f)
            {
                Student.Ocena = 5.00f;
            }
            else
            {
                Student.Ocena = Ocena;
            }
        }
        static float WyliczSrednia(Student[] studenci)
        {
            float sum = 0;
            foreach(Student student in studenci)
            {
                sum += student.Ocena;
            }
            float srednia = sum / studenci.Length;
            return srednia;
        }
        static void Wyswietlanie(Student student)
        {
            
            Console.WriteLine("Nazwisko: " + Student.Nazwisko + "Nr Albumu: " + Student.NrAlbumu + "Ocena: " + Student.Ocena + "Plec: " + Student.Plec);
            Console.WriteLine();
        }
    }
}