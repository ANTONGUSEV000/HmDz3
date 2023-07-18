  Random random = new Random();

        // Задаем размер массива
        int size = 100;

        // Создаем массив
        int[] numbers = new int[size];

        // Заполняем массив случайными положительными трехзначными числами
        for (int i = 0; i < size; i++)
        {
            numbers[i] = random.Next(100, 1000);
        }

        // Переменная для подсчета количества четных чисел
        int evenCount = 0;

        // Перебираем все элементы массива и проверяем их на четность
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                evenCount++;
            }
        }

        // Выводим результат
        Console.WriteLine("Количество четных чисел: " + evenCount);
    
