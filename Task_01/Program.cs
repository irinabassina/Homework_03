// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Input a five-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

int num1 = number / 10000 % 10;
int num2 = number / 1000 % 10;
int turn1 = number / 10 % 10;
int turn2 = number % 10;
int outnum = number / 10000;

if (outnum < 1 || outnum > 9)
{
    Console.WriteLine($" {number} -> Not a five-digit number");
}
else if (num1 == turn2 && num2 == turn1)
{
    Console.WriteLine($" {number} -> Yes");
}
else
{
    Console.WriteLine($" {number} -> No");
}