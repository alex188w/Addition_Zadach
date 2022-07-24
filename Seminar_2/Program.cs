void Zadacha3()
{
    // Задача 3. Иван в начале года открыл счет в банке, вложив 1000 руб. 
    // Через каждый месяц размер вклада увеличивается на 1.5% от имеющейся суммы. 
    // Определить размер депозита через n месяцев
    Random rand = new Random();
    double deposit = 1000;
    int month = rand.Next(1, 1000);
    for (int i = 0; i < month; i++)
    {
        deposit = deposit * 1.015;
    }
    Console.WriteLine($"Сумма депозита через {month} месяцев составляет {Math.Round(deposit, 2)} рубля");
}

void Zadacha4()
// Задача 4. Дано натуральное число, в котором все цифры различны. Определить, 
// какая цифра расположена в нем левее: максимальная или минимальная
//697284105
{
    int number = 697284105;
    int max = -1;
    int min = 10;
    int positionMax = 0;
    int positionMin = 0;
    int count = 1;
    Console.Write($"В числе {number} ");

    while (number > 0)
    {
        int digit = number % 10;
        if (digit > max)
        {
            max = digit;
            positionMax = count;
        }
        else if (digit < min)
        {
            min = digit;
            positionMin = count;
        }
        count++;
        number /= 10;
    }
    
    if (positionMax > positionMin)
    {
        Console.WriteLine($"цифра {max} стоит левее цифры {min}");        
    }
    else Console.WriteLine($"цифра {min} стоит левее цифры {max}");
}

//Zadacha3();
Zadacha4();


