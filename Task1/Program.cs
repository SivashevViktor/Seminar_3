Console.Write("Введите X:");
int X = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите Y:");
int Y = Convert.ToInt32(Console.ReadLine());

if (X == 0 || Y == 0) Console.WriteLine("X и/или Y = 0. Невозможно определить четверть");
else
{
    if (X > 0 && Y > 0) Console.WriteLine("Точка находиться в первой четверти");
    if (X < 0 && Y > 0) Console.WriteLine("Точка находиться в второй четверти");
    if (X < 0 && Y < 0) Console.WriteLine("Точка находиться в третьей четверти");
    if (X > 0 && Y < 0) Console.WriteLine("Точка находиться в четвертой четверти");
}