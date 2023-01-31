// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
string strNumber = Console.ReadLine();
int number = Convert.ToInt32(strNumber);
int Length = number.ToString().Length;
if (Length == 3)
{
    int result = (number / 10) % 10;
    Console.WriteLine("Вторая цифра числа -> " + result);
}
else
{
    Console.WriteLine("Это число не трехзначное!");
}
