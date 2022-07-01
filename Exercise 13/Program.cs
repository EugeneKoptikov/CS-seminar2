// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Программа для нахождения и вывода второй цифры в трехзначом числе!");
Console.Write("Введите трехзначное число: ");
string number = Console.ReadLine();

if (number.Length >= 3)
{
    char thirdChar = number[2];
    Console.WriteLine("Искомая цифра " + thirdChar);
} 
if (number.Length < 3 ) {
    Console.WriteLine("Неверно введено число!");
}