Console.Write("Введите ваше имя: ");
string name = Console.ReadLine();

Console.WriteLine($"Привет, {name}");

string[] days = { "Воскресенье", "Понедельник", "Вторник", "Среда","Четверг", "Пятница", "Суббота" };
Console.WriteLine($"Сегодня {days[(int)DateTime.Now.DayOfWeek]}");

Console.Write("Хотите продолжить? (y/n): ");
string answer = Console.ReadLine();

if (answer == "y" || answer == "Y")
{
    Console.WriteLine("Продолжаем работу");
}
else
{
    Console.WriteLine("Выход из программы");
}
