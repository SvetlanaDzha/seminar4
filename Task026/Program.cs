// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// Не используем в решении задачи строки и ее свойства

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count;

for (count = 1; number >= 10; count++)
{
    number /= 10;
}
Console.WriteLine(count);


// int count = 0;
// int result = number;
// for (result = number; result > 0; count++) result = result /10;

// Console.WriteLine($"В числе {number} {count} цифр");
