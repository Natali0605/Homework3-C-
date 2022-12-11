// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет  12821 -> да  23432 -> да

void Polindrom(int number)
{
int a1 = number / 10000;
int a5 = number % 10;
int a2 = number / 1000;
int a22 = number % 10;
int a4 = number / 10;
int a44 = number % 10;

if (a1 == a5 && a22 == a44)
{
    Console.WriteLine("Чилсло " + number + " является палиндромом");
}
    else
{
    Console.WriteLine("Чилсло " + number + " не является палиндромом");
}
}
Console.WriteLine("Введите пятизначное число");
int number = int.Parse(Console.ReadLine());
Polindrom(number);



