// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string snumber = number.ToString();
if (snumber.Length < 3) 
{Console.WriteLine("нет третьей цифры");}

else
{char c = snumber[2];
Console.WriteLine(c);
}