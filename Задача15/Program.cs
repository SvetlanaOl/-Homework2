// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

Console.Write("Введите день недели в формате цифры: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber==6 | dayNumber==7)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
if (dayNumber>7)
{
    Console.WriteLine("Число не соответствует дню недели");
}