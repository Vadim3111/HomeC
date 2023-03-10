Console.Clear();
Console.Write("Введите 1-ое число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-ое число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3-ое число: ");
int k = int.Parse(Console.ReadLine()!);
if (n > m & n > k ) 
Console.WriteLine($"{n}");
else if (m > n & m > k)
Console.WriteLine($"{m}");
else if (k > n & k > m)
Console.WriteLine($"{k}");