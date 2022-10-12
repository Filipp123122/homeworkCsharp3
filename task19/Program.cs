/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
int number = new Random().Next(10000,99999);
Console.WriteLine(number);
int firstDigit = number / 10000;
int lastDigit = number % 10;
if(firstDigit == lastDigit)
{
    Console.Write ("да");
}
else
{
    Console.Write ("нет");
}