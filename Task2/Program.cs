Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int m = int.Parse(Console.ReadLine()!);
if (m > n)
    Console.WriteLine($"Max = {m}");
else 
    Console.WriteLine($"Max = {n}");