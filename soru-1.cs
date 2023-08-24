using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Metin giriniz: ");
        string inputText = Console.ReadLine();

        string cleanedText = CleanText(inputText);

        Console.WriteLine("Girdi: " + inputText);
        Console.WriteLine("Temizlenmis Metin: " + cleanedText);
    }

    static string CleanText(string input)
    {
        // Birden fazla boslugu tek bosluga cevirme
        string cleaned = System.Text.RegularExpressions.Regex.Replace(input, @"\s+", " ");

        // Noktalama isaretlerinden sonra bosluk birakma kontrolu
        cleaned = System.Text.RegularExpressions.Regex.Replace(cleaned, @"(\w)([.,!?])", "$1$2 ");

        return cleaned.Trim();
    }
}	  