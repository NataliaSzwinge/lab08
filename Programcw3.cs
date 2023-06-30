using System;
namespace cw3
    enum KlasaRzadkosci
{
    Powszechny = 1,
    Rzadki,
    Unikalny,
    Epicki
}
    enum TypPrzedmiotu
{
    Bron,
    Zbroja,
    Amulet,
    Pierscien,
    Helm,
    Tarcza,
    Buty
}
    struct Przedmiot
{
    public float Waga;
    public int Wartosc;
    public string Nazwa;
    public KlasaRzadkosci Rzadkosc;
    public TypPrzedmiotu Typ;
}
class Program
{
    static void WypelnijPrzedmiot(ref Przedmiot przedmiot, float Waga, int Wartosc, string Nazwa, KlasaRzadkosci Rzadkosc, TypPrzedmiotu Typ)
    {
        if (Waga >= 0)
        {
            Przedmiot.Waga = Waga;
        }
        else
        {
            Przedmiot.Waga = 0;
        }
        if (Waga >= 0)
        {
            Przedmiot.Wartosc = Wartosc;
        }
        else
        {
            Przedmiot.Wartosc = 0;
        }
        Przedmiot.Nazwa = Nazwa;
        Przedmiot.Rzadkosc = Rzadkosc;
        Przedmiot.Typ = Typ;
    }
    static void Wyswietl(Przedmiot przedmiot)
    {
        Console.WriteLine($"Przedmiot: {Przedmiot.Nazwa}");
        Console.WriteLine($"Wartosc: {Przedmiot.Wartosc}");
        Console.WriteLine();
    }
    static Przedmiot LosujPrzedmiot(Przedmiot[] Skrzynka)
    {
        Random random = new Random();
        Array.Sort(Skrzynka, PorownajPrzedmioty);
        int SumaRzadkosci = 0;
        foreach(int Przedmiot przedmiot in Skrzynka)
        {
            SumaRzadkosci += (int)przedmiot.Rzadkosc;
        }
        int losowanaRzadkosc = random.Next(1, SumaRzadkosci + 1);
        int AktualnaSuma = 0;
        foreach(var przedmiot in Skrzynka)
        {
            AktualnaSuma += (int)przedmiot.Rzadkosc;
            if(AktualnaSuma>=losowanaRzadkosc)
            {
                return przedmiot;
            }
        }
        return Skrzynka[0];
    }
    static int PorownajPrzedmioty(Przedmiot p1, Przedmiot p2)
    {
        if (p1.Rzadkosc < p2.Rzadkosc)
        {
            return -1;
        }
        else if (p1.Rzadkosc == p2.Rzadkosc)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
    static void Main(string[] args)
    {
        Przedmiot[] przedmioty[5] = new Przedmiot[5];
        WypelnijPrzedmiot(ref przedmioty[0], 1.5f, 10, "MIecz", KlasaRzadkosci.Powszechny, TypPrzedmiotu.Bron);
        WypelnijPrzedmiot(ref przedmioty[0], 2.5f, 1000, "Naszyjik", KlasaRzadkosci.Unikalny, TypPrzedmiotu.Amulet);
        WypelnijPrzedmiot(ref przedmioty[0], 3.5f, 10000, "Zbroja", KlasaRzadkosci.Epicki, TypPrzedmiotu.Zbroja);

        Przedmiot wylosowany = LosujPrzedmiot(przedmioty);

    }
}