void Zadacha_4()
// Задача 4. Дан массив длиной 10 элементов. Заполнить его 
// последовательно числами от 1 до 10.
{
    int[] nums = new int[10]; // создать новый массив с N элементами
                                // по умолчанию будет наполнен нулями    
     
    int index = 0;
    int number = 1;

    for (int i = 0; i < nums.Length; i++)
    {
        nums[index] = number;
        Console.Write( nums[index] + " ");
        number++;
        index++;
    }
    Console.WriteLine();
    Console.WriteLine(nums[8]);   
}

// void Zadacha_1_Power()
// Задача 1. На ввод подаётся номер четверти. Создаются 3 случайные точки
// в этой четверти. Определите самый оптимальный маршрут для торгового менеджера, 
// который выезжает из центра координат.

// void Zadacha_2_Power()
// Задача 2. Даны 4 точки a, b, c, d. Пересекаются ли вектора AB и CD?





void Zadacha_7_Power()
//Задача 7. Массив из ста элементов заполняется случайными числами от 1 до 100. 
// Удалить из массива все элементы, содержащие цифру 3. Вывести в консоль 
//новый массив и количество удалённых элементов.

{
    int[] nums = new int[100];
    int length = nums.Length;
    int index = 0;
    int count = 0;
    while (index < length)
    {
    nums[index] = new Random().Next(1, 100);
    Console.Write(nums[index] + " ");
    index++;    
    }
    Console.WriteLine();
    for (index = 0; index < 100; index++)
    {
        if(nums[index] == 3)
        {
            index = index + 1;
            count = count + 1;
            length = length - 1;
        }        
    Console.Write(nums[index] + " ");        
    }
    Console.WriteLine();
    Console.WriteLine($"Количество удаленных элементов составило {count}"); 

}


// Zadacha_4();
// Zadacha_4_Power();
// Zadacha_7_Power();