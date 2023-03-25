var rand = new Random();

var chancesCount = 5;
var successNumber = rand.Next(0, 101);
var higher = rand.Next(successNumber + 1, successNumber + 8);
var lower = rand.Next(successNumber - 8, successNumber);

Console.WriteLine(@"Вас приветстует игра ""Угадай число"".");
Console.WriteLine($"Число которое вы должны найти, находится в диапазоне от {lower} до {higher}, у вас 5 попыток.");

StartGame(chancesCount, successNumber);

static void StartGame(int chancesCount, int successNumber)
{
    var isWin = false;
    do
    {
        Console.Write($"Ваш вариант ответа:");
        var userNumber = Convert.ToInt32(Console.ReadLine());
        if (userNumber == successNumber)
        {
            isWin = true;
            break;
        }
        else
            Console.WriteLine($"Неверно, у вас осталось {chancesCount} попыток.");
    } while (--chancesCount > 0);

    if (isWin)
        Console.WriteLine("Поздравляю, вы выиграли!");
    else 
        Console.WriteLine($"Вы проиграли, загаданное число ровнялось: {successNumber}.");
}