// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Программа для нахождения и вывода второй цифры в трехзначом числе!");
Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();

if (number.Length == 3)
{
    char secondChar = number[1];
    Console.WriteLine("Искомая цифра " + secondChar);
} 
if (number.Length <3 || number.Length > 3) {
    Console.WriteLine("Неверно введено число!");
}