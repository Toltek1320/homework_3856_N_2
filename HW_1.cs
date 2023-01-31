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

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
string strNumber = Console.ReadLine();
int number = Convert.ToInt32(strNumber);
int Length = number.ToString().Length;
if (Length >= 3)
{
    while (number > 999)
    {
        number = number / 10;
    }
    int result = number % 10;
    Console.WriteLine("Третья цифра числа -> " + result);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

Console.WriteLine("Введите день недели: ");
string strNumber = Console.ReadLine();
int number = Convert.ToInt32(strNumber);
if (number >= 1 && number <= 5)
{
    Console.WriteLine("Это рабочий день");
}
else if (number >= 6 && number <= 7)
{
    Console.WriteLine("Это выходной день");
}
else
{
    Console.WriteLine("Это не день недели");
}
