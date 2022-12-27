// Задача 1

System.Console.WriteLine("Введите пятизначное число: ");
int num = Convert.ToInt32(System.Console.ReadLine());

string num3 = Convert.ToString(num);
if (num3[0] == num3[4] && num3[1] == num3[3])
{
        System.Console.Write($"Число {num3} - Полиндром!");
}
else
{
        System.Console.Write($"Число {num3} - Не полиндром");
}

// Задача 2

System.Console.WriteLine("Введите координату X точки A: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y точки A: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z точки A: ");
int z1 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координату X точки B: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Y точки B: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите координату Z точки B: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Round(Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2) + Math.Pow((z1 - z2),2)),2); 
System.Console.WriteLine($"Расстояние между тремя точками: {result}");