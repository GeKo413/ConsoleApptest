Console.WriteLine("Hello, World!");

Console.Write("Adj meg egy pozitív egész számot:");

int szam = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= szam; i++)
{
    Console.WriteLine($"A számláló értéke:{i}");
}
