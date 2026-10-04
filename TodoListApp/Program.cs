Console.WriteLine("Работу выполнили Сипач и Пасалиди");

Console.Write("Введите имя: ");
string name1 = Console.ReadLine();

Console.Write("Введите фамилию: ");
string name2 = Console.ReadLine();

Console.Write("Введите год рождения: ");
string yearinput = Console.ReadLine();
int year = int.Parse(yearinput);

int curyear = DateTime.Now.Year;
int age = curyear - year;
Console.WriteLine($"Добавлен пользователь {name2} {name1}, возраст - {age}");