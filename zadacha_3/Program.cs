/*Задача 3: * Найдите сумму произведений пар чисел в одномерном целочисленном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Если кол-во элементов нечетное, то элемент посередине не учитывать.
Результат сложения вывести на экран.

1, 3, 8, 3, 2 -> 11

8, 3, 4, 2 -> 28
*/
 Console.Write("Введите размер массива: ");
 int N = Convert.ToInt32(Console.ReadLine());
 int[] array = new int[N];
Console.BackgroundColor = ConsoleColor.DarkCyan;
Console.Write("В массиве ====>" );

 for (int i =0; i< N; i++)
 {
     array[i] = new Random().Next(1, 10);
 Console.Write( " "+(array[i])  );
 }
 
int[] newArray = new int[array.Length/2]; 
int j = array.Length-1; 
int sum = 0; 
for(int i = 0; i < array.Length/2; i++) 
{ 
    newArray[i] = array[i] * array[j]; 
    sum += newArray[i]; 
    j--;    
} 
Console.WriteLine();
Console.BackgroundColor = ConsoleColor.DarkCyan;
Console.WriteLine("сумма произведений пар чисел ====>" + sum);