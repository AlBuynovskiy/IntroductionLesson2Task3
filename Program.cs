// See https://aka.ms/new-console-template for more information
/*
Напишите программу, которая принимает на вход цифру, обозначающую день недели,
и проверяет, является ли этот день выходным.
*/

Console.WriteLine("Введите число соотвествующее дню недели");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 | number == 7)
{
    Console.WriteLine("Этот день выходной");
}
else

if (number > 0 & number < 6)
{
    Console.WriteLine("Этот день рабочий");
}
else

Console.WriteLine("Вы ввели несуществующий день недели.");