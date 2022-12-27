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

