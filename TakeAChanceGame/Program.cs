var rand = new Random();

int[] array = new int[45];

for (int i = 0; i < 45; i++)
{
    array[i] = i;
}

var chancesCount = 5;
var successNumber = rand.Next(0, 101);
var higher = rand.Next(successNumber + 1, successNumber + 8);
var lower = rand.Next(successNumber - 8, successNumber);

Console.WriteLine(@"Вас приветстует игра ""Угадай число"".");
Console.WriteLine($"Число которое вы должны найти, находится в диапазоне от {lower} до {higher}, у вас 5 попыток.");

StartGame(chancesCount, successNumber);

static void StartGame(int chancesCount, int successNumber)
{
    for (int i = 0; i < chancesCount; i++)
    {
        Console.Write($"Ваш вариант ответа:");
        var userNumber = Convert.ToInt32(Console.ReadLine());
        if (userNumber == successNumber)
        {
            Console.WriteLine("Поздравляю, вы выиграли!");
            break;
        }
        else
        {
            Console.WriteLine($"Неверно, у вас осталось {chancesCount} попыток.");
        }
    }

    if (chancesCount < 0)
    {
        Console.WriteLine($"Вы проиграли, загаданное число ровнялось: {successNumber}.");
    }
}