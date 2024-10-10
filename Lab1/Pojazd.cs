using System;

// Klasa bazowa
class Pojazd
{
    // Właściwości
    public string? Marka;
    public string? Model;
    public int RokProdukcji;

    // Metody
    public virtual void Uruchom()
    {
        Console.WriteLine($"Uruchamianie pojazdu: {Marka} {Model}");
    }


    public void Info()
    {
        Console.WriteLine($"Marka: {Marka}, Model: {Model}, Rok: {RokProdukcji}");
    }
}

// Klasa pochodna
class Samochod : Pojazd
{
    public int LiczbaDrzwi;

    // Przesłonięcie metody
    public override void Uruchom()
    {
        Console.WriteLine($"Uruchamianie samochodu: {Marka} {Model} z {LiczbaDrzwi} drzwiami.");
    }
}

// Klasa pochodna
class Motocykl : Pojazd
{
    public bool MaOwiewke;

    // Przesłonięcie metody
    public override void Uruchom()
    {
        Console.WriteLine($"Uruchamianie motocykla: {Marka} {Model}. Ma owiewkę: {MaOwiewke}");
    }
}
