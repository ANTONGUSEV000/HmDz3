﻿// Задаем массив вещественных чисел
        double[] numbers = { 2.5, 1.8, 3.7, 4.2, 2.1, 5.0 };

        // Находим минимальный элемент массива
        double min = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] < min)
            {
                min = numbers[i];
            }
        }

        // Находим максимальный элемент массива
        double max = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > max)
            {
                max = numbers[i];
            }
        }

        // Находим разницу между максимальным и минимальным элементами
        double difference = max - min;

        // Выводим результат
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
