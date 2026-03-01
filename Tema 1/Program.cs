using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Salariu";
        int numar_de_ore = 0;
        double tarif = 0.0;
        double salariu = 0.0;
        Console.WriteLine("Ore lucrate: ");
        string numar_de_ore_str = Console.ReadLine();
        Console.WriteLine("Tarif: ");
        string tarif_str = Console.ReadLine();
        int.TryParse(numar_de_ore_str, out numar_de_ore);
        double.TryParse(tarif_str, out tarif);

        salariu = tarif * numar_de_ore;
        if (salariu > 3000)
        {
            Console.WriteLine("Esti bogat: " + salariu + "lei");
        }
        else
        {
            Console.WriteLine("Ati lucrat putini: " + salariu + "lei");
        }
    }
}