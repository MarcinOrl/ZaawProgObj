using System;

class Program
{
    static void Main(string[] args)
    {
        // Tworzenie obiektów
        Pojazd mojSamochod = new Samochod
        {
            Marka = "Toyota",
            Model = "Corolla",
            RokProdukcji = 2020,
            LiczbaDrzwi = 4 
        };

        Pojazd mojMotocykl = new Motocykl
        {
            Marka = "Kawasaki",
            Model = "Ninja",
            RokProdukcji = 2021,
            MaOwiewke = true
        };

        // Wywołanie metod
        mojSamochod.Info();
        mojSamochod.Uruchom();

        mojMotocykl.Info();
        mojMotocykl.Uruchom();
    }
}
