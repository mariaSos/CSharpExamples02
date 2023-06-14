// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
System.Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number/100 == 0 || number/100 > 9){
    System.Console.WriteLine("Введено не трехзначное число!");
}
else
{
System.Console.WriteLine($"Вторая цифра от числа {number}: {number/10}");
}
