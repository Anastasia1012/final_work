using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Итоговая проверочная работа.
             * 1.Создать репозиторий на GitHub
             * 2.Нарисовать блок - схему алгоритма(можно обойтись блок - схемой основной содержательной части,
            если вы выделяете ее в отдельный метод)
               3.Снабдить репозиторий оформленным текстовым описанием решения(файл README.md)
               4.Написать программу, решающую поставленную задачу   
               5.Использовать контроль версий в работе над этим небольшим проектом
               (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены
               в разных коммитах)

            **Задача * *: Написать программу, которая из имеющегося массива строк формирует массив из строк,
            *длина которых меньше либо равна 3 символа.Первоначальный массив можно ввести с клавиатуры,
            *либо задать на старте выполнения алгоритма.При решении не рекомендуется пользоваться коллекциями,
            *лучше обойтись исключительно массивами.

            * *Примеры * *:

            ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

            ["1234", "1567", "-2", "computer science"] -> ["-2"]

            ["Russia", "Denmark", "Kazan"] -> []*/

            Console.WriteLine("Написать программу, которая из имеющегося массива строк формирует массив из строк," +
                "длина которых меньше либо равна 3 символа");
            string[] Str;
            Str = new string[] { "hello", "2", "world", ":-)" };
            for (int i = 0; i < Str.Length; i++)
            {
                Console.Write(Str[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < Str.Length; i++)
            {
                if (Str[i].Length <= 3)
                { }

            }


        }
    }
}
