// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void SqurePrinter(int numberN)
{
    int current = 1;
    while (current <= numberN)
    {
        double res = Math.Pow(current, 3);
        Console.Write($"{res:f0}, ");
        current++;
    }
    Console.WriteLine("\b\b ");     // удаляет пробел и запятую в конце строки
}
void SqurePrinterNeg(int numberN)
{
    int current = 1;
    while (current >= numberN)
    {
        double res = Math.Pow(current, 3);
        Console.Write($"{res:f0}, ");
        current--;
    }
    Console.WriteLine("\b\b ");
}

Console.Write("Input number: ");
int user_number = Convert.ToInt32(Console.ReadLine());

if (user_number > 0)
    SqurePrinter(user_number);
else
    SqurePrinterNeg(user_number);

