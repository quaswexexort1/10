
//ИНТЕРВАЛ [2;4]
double s = 2;
double e = 4;

//ШАГ ТАБУЛИРОВАНИЯ
double step = 0.2;

Console.WriteLine("x     |     y");
Console.WriteLine("-------------");

for (double x = s; x <= e; x += step)
{
    double y = CF(x);
    Console.WriteLine($"{x:F2} | {y:F2}");
}

// Функция для вычисления значения функции y = x^3 + 3x^2 - 3
static double CF(double x)
{
    return Math.Pow(x, 3) + 3 * Math.Pow(x, 2) - 3;
}

