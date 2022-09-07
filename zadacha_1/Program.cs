/*Задача 1: Программа запрашивает натуральное число M, пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.Write("Введите колличество чисел: ");
int M = Convert.ToInt32(Console.ReadLine());

int count = 0;
for (int i = 0; i < M; i++)
{
    Console.Write($"Введите натуральное число {i + 1}: ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a > 0)
    {
        count++;
    }     
}        
Console.BackgroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("Пользователь ввел  чисел больше 0 ====> " + count);

