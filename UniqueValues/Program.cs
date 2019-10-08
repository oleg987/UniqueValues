using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueValues
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fill1DArrayUnique();
            //Fill1DArrayUnique(10); // Массив из 10 элементов, значения от 0 до 100
            //Fill1DArrayUnique(500, 0, 1000); // Массив из 500 элементов, значения от 0 до 1000
            Fill1DArrayUnique(500, 0, 100); // Исключение, недостаточно значений
        }


        /* Входные параметры:
         * size - размер массива (если не указано, то по умолчанию будет 100)
         * min_val - минимальное значение (если не указано, то по умолчанию будет 0)
         * max_val - максимальное значение (если не указано, то по умолчанию будет 100)
         */
        private static void Fill1DArrayUnique(int size = 100, int min_val = 0, int max_val = 100)
        {
            // Проверка на то что в заданом диапазоне достаточно уникальных значений для заполнения массива
            if ((max_val - min_val) < size)
            {
                // Если недостаточно - получаем исключение
                throw new NotImplementedException("Error: Range of random values not enough to fill array with unique values!");
            }

            // Инициализация массива
            int[] array = new int[size];

            // Инициализация рандомизатора
            Random rand = new Random();

            // Переменная для проверки значения на уникальность
            bool unique;

            // Переменная для случайного значения
            int unique_val;

            for (int i = 0; i < size;)
            {
                unique = true;

                // Генерируем случайное значение
                unique_val = rand.Next(min_val, max_val);

                
                for (int j = 0; j < i; j++)
                {
                    // В цикле проверяем значение на равенство с предыдущими значениями
                    if (unique_val == array[j])
                    {
                        unique = false; // Значение не уникально
                        break; // Дальнейшая проверка не обязательна, прерываем цикл
                    }
                }

                // Если значение уникально
                if (unique)
                {
                    array[i] = unique_val; // Добавляем в массив
                    i++; // Увеличиваем счетчик, переходим к следующей итерации
                }

                // Если значение не уникально, запускаем ту же итерацию и генерируем новое число
            }

            // Вывод на консоль
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
