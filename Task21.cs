Console.WriteLine("Введите координату X точки A");
int x1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y точки A");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z точки A");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату X точки B");
int x2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Y точки B");
int y2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату Z точки B");
int z2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2)));
