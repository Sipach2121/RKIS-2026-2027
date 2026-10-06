Console.WriteLine("Работу выполнили Сипач и Пасалиди");

//Практическая работа №2
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
Console.WriteLine();

//Практическая работа №3
string[] todos = new string[2];
int todoCount = 0;

while (true)
{
    Console.Write("> ");
    string input = Console.ReadLine();
    if (input == "exit")
    {
        Console.WriteLine("завершение программы");
        break;
    }
    else if (input == "help")
    {
        Console.WriteLine("Доступные команды:");
        Console.WriteLine("help - список команд");
        Console.WriteLine("profile - данные пользователя");
        Console.WriteLine("add 'текст' - добавить задачу");
        Console.WriteLine("view - показывать задачи");
        Console.WriteLine("exit - выход");
    }
    else if (input == "profile")
    {
        Console.WriteLine($"{name1} {name2}, {year}");
    }
    else if (input.StartsWith("add "))
    {
        string task = input.Substring(4).Trim('"');
        if (todoCount >= todos.Length)
        {
            string[] newTodos = new string[todos.Length * 2];
            for (int i = 0; i < todos.Length; i++)
            {
                newTodos[i] = todos[i];
            }
            todos = newTodos;
            Console.WriteLine("массив расширен");
        }
        todos[todoCount] = task;
        todoCount++;
        Console.WriteLine($"Задача добавлена: {task}");
    }
    else if (input == "view")
    {
        bool hasTasks = false;
        for (int i = 0; i < todos.Length; i++)
        {
            if (!string.IsNullOrEmpty(todos[i]))
            {
                Console.WriteLine($"[{i +1}] {todos[i]}");
                hasTasks = true;
            }
        }
        if (!hasTasks) Console.WriteLine("Список задач пуст");
    }
    else
    {
        Console.WriteLine("Неизвестная команда.Введите help");
    }
}
    
     
