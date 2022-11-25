// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7: ");
int a = int.Parse(Console.ReadLine());

  if (a >= 1 && a <= 7)
{
  if (a == 6 | a == 7) Console.WriteLine("да");
  else Console.WriteLine("нет");
}

else
{
    Console.Write("Вы ввели неверное число");
}
