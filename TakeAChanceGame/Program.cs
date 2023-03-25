Random rand = new Random();
int number, lower, higher;
int userNumber;
int chances;
chances = 5;
number = rand.Next(0, 101);
higher = rand.Next (number + 1, number + 8);
lower = rand.Next (number - 8, number);
Console.WriteLine(@"Вас приветстует игра ""Угадай число"".");
Console.WriteLine($"Число которое вы должны найти, находится в диапазоне от {lower} до {higher}, у вас 5 попыток.");
while (chances-- > 0)
{
    Console.Write($"Ваш вариант ответа:");
    userNumber = Convert.ToInt32(Console.ReadLine());
    if ( userNumber == number )
    {
        Console.WriteLine("Поздравляю, вы выиграли!");
        break;
    }
    else
    {
        Console.WriteLine($"Неверно, у вас осталось {chances} попыток.");
    }
}
if (chances < 0)
{
    Console.WriteLine($"Вы проиграли, загаданное число ровнялось: {number}.");
}