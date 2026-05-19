int zahl;
int counter = 0;

Console.WriteLine("Gib die zu überprüfende Zahl ein: ");
zahl = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= zahl; i++)
{
    if (zahl % i == 0)
    {
        counter++;
    }
}
if (counter == 2)
{
    Console.WriteLine(zahl + " ist eine Primzahl");
}
else
{
    Console.WriteLine(zahl + " ist keine Primzahl");
}
