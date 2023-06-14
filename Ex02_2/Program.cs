// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number/100 == 0){
    System.Console.WriteLine("Третьей цифры в числе нет");
}
else{
    while(number/10 > 100){
        number = number/10;
    }
    System.Console.WriteLine($"Третья цифра в числе: {number%10}");
}
