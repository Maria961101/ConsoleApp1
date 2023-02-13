using System;
namespace program
{
    internal class Program
    { 
        static void Main (string[] args)
        {

            Book book = new Book();
            Book secondBook = new Book();
            Magazine magazine = new Magazine();
            Magazine secondMagazine = new Magazine();
            Printable[] printable = { book, secondMagazine, magazine, secondBook };
            foreach (Printable item in printable)
            {
                item.Print();
            }
            Book.printBook(printable);
            Magazine.printMagazines(printable);
            Guitar guitar = new Guitar(10);
            Drum drum = new Drum(7);
            Trumpet trumpet = new Trumpet(90);
            Instrument[] instruments = { guitar, drum, trumpet };
            foreach (Instrument item in instruments)
            {
                item.Play();
            }
        }
}
interface Printable
{
    void Print();
}
class Book : Printable
{
    public static void printBook(Printable[] printable)
    {
        foreach (var item in printable)
        {
            if (item.GetType() == typeof(Book))
            {
                item.Print();
            }
        }
    }
    public void Print()
    {
        Console.WriteLine("Сборники книгй");
    }
}
class Magazine : Printable
{
    public static void printMagazines(Printable[] printable)
    {
        foreach (var item in printable)
        {
            if (item.GetType() == typeof(Magazine))
            {
                item.Print();
            }
        }
    }
    public void Print()
    {
        Console.WriteLine("Сборники журналов");
    }
}
interface Instrument
{
    void Play();
    const string KEY = "До Мажор";
}
class Guitar : Instrument
{
    public Guitar(int stringsCount)
    {
        this.stringsCount = stringsCount;
    }
    private int stringsCount;

    public void Play()
    {
        Console.WriteLine("Играет гитара со следующими характеристиками = "+stringsCount);
    }
}
class Drum : Instrument
{
    public Drum(int size)
    {
        this.size = size;
    }
    private int size;

    public void Play()
    {
        Console.WriteLine("Играет барабан со следующими характеристиками = "+size);
    }
}
class Trumpet : Instrument
{
    public Trumpet(int diameter)
    {
        this.diameter = diameter;
    }
    private int diameter;

    public void Play()
    {
        Console.WriteLine("Играет труба со следующими характеристиками = "+diameter);
    }
}
}
