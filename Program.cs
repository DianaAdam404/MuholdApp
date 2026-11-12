using MuholdApp;
using System.Security.Cryptography.X509Certificates;

List<Muhold> muholdak = new List<Muhold>();
int hibasSorokSzama = 0;

foreach (string sor in File.ReadLines("muholdak.txt").Skip(1))
{
    if (string.IsNullOrWhiteSpace(sor))
    {
        hibasSorokSzama++;
        continue;
    }

    string[] adatok = sor.Split('|');
    if (adatok.Length != 4)
    {
        hibasSorokSzama++;
        continue;
    }
    if (!int.TryParse(adatok[2], out int sulyKg) || !int.TryParse(adatok[3], out int muszerek)
    {
        hibasSorokSzama++;
        continue;
    }
    if (adatok[0] == "M")
    {
        muholdak.Add(new Muhold(adatok[1], sulyKg));
    }
    else if (!int.TryParse(adatok[3], out int muszerek))
    {
        hibasSorokSzama++;
        continue;
    }

    string tipus = adatok[0].Trim();
    string azonosito = adatok[1].Trim();
    string sulykg = adatok[2].Trim();
    string extra = adatok[3].Trim();

    if ((tipus != "K" && tipus != "M")) { hibasSorokSzama++; continue; }
    if (adatok[0] == "M") muholdak.Add(new Muhold(adatok[1], sulyKg));
    else muholdak.Add(new KutatasiMuhold(adatok[1], sulyKg, muszerek));
}
Console.WriteLine($"Sikeresenbeolvasott muholdak: {muholdak.Count} db");
Console.WriteLine($"Kiszurthibas sorok szama: {hibasSorokSzama} db");
Console.WriteLine("\nBEolvasott muholdak listaja00000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000")
