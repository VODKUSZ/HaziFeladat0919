using System;
using System.Collections.Generic;
class Szemely
{
    private string nev;
    private int suly;
    private double magassag;

    public Szemely(string nev, int suly, double magassag)
    {
        this.nev = nev;
        this.suly = suly;
        this.magassag = magassag;
    }
    public string Nev 
    {
        get { return nev; }
        set { nev = value; }
    }
    public int Suly 
    {
        get { return suly; }
        set { suly = value; }
    }
    public double Magassag 
    {
        get { return magassag; }
        set { magassag = value; }
    }
    public double GetTTI()
    {
        return suly / (magassag * magassag);
    }

    public string GetAlkat()
    {
        double tti = GetTTI();
        if (tti < 18.5)
            return "sovány";
        else if (tti > 25)
            return "kövér";
        else
            return "normál";
    }

    public override string ToString()
    {
        return $"{nev}, súly: {suly} kg, magasság: {magassag} m, "
            + $"TTI: {GetTTI():0.00}, alkat: {GetAlkat()}";
    }
}
internal class Program
{

    static void Main(string[] args)
    {
        List<Szemely> szemelyek = new List<Szemely>();
        Console.Write("Hány személy adatait szeretnéd megadni? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\n{i + 1}. személy:");
            Console.Write("Név: ");
            string nev = Console.ReadLine();

            Console.Write("Súly (kg): ");
            int suly = int.Parse(Console.ReadLine());

            Console.Write("Magasság (m): ");
            double magassag = double.Parse(Console.ReadLine());

            szemelyek.Add(new Szemely(nev, suly, magassag));
        }

        Console.WriteLine("\n--- Eredmények ---");
        foreach (var sz in szemelyek)
        {
            Console.WriteLine(sz);
        }
    }
}