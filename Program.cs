using System.Collections.Generic;

// List<string> tasks = new List<string> { "Код", "Тест","Код"};
// System.Console.WriteLine(tasks.Count);

// tasks.Add("Отчёт");
// tasks.Insert(1, "План");

bool InsertTaskSafe(List<string> tasks, int index, string title)
{
    if (index < 0 || index > tasks.Count)
    {
        return false;
    }

    tasks.Insert(index, title);
    return true;
}

// List<string> emptyTasks = new List<string>();
// emptyTasks.Add("Код");
// System.Console.WriteLine(emptyTasks.Count);


void PrintTasks(List<string> tasks)
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("Список пуст");
        return;
    }

    for (int i = 0; i < tasks.Count; i++)
    {
        System.Console.WriteLine($"{i}: {tasks[i]}");
    }
}

// PrintTasks(tasks);


// List<string> removedTasks = new List<string> { "Код", "Тест", "Код" };

// bool removed = removedTasks.Remove("Код");
// System.Console.WriteLine(removed);
// PrintTasks(removedTasks);


// Console.WriteLine(removedTasks.Remove("Экзамен"));
// Console.WriteLine(removedTasks.Count);

// removedTasks.RemoveAt(1);
// PrintTasks(removedTasks);


bool RemoveTaskAtSafe(List<string> tasks, int index)
{
    if (index < 0 || index >= tasks.Count)
    {
        return false;
    }
    tasks.RemoveAt(index);
    return true;
}

// List<int> scores = new List<int> { 10, 20, 30 };
// scores.RemoveAt(1);

// List<string> searchableTasks = new List<string> { "Код", "Тест", "Код" };

// Console.WriteLine(searchableTasks.Contains("Код"));
// Console.WriteLine(searchableTasks.Contains("План"));
// Console.WriteLine(searchableTasks.IndexOf("Код"));
// Console.WriteLine(searchableTasks.IndexOf("План"));


// int index = searchableTasks.IndexOf("Код");

// if (index == 0)
// {
//     Console.WriteLine($"Первый индекс: {index}");
// }
// else
// {
//     Console.WriteLine("Задача не найдена");
// }

Console.Write("Сколько задач добавить сначала: ");
int count = Convert.ToInt32(Console.ReadLine());

List<string> tasks = new List<string>();

for (int i = 0; i < count; i++)
{
    Console.Write($"Задача {i + 1}: ");
    string title = Console.ReadLine() ?? "";
    tasks.Add(title);
}


PrintTasks(tasks);

Console.Write("Новая задача для добавления в конец: ");
string add = Console.ReadLine() ?? "";
tasks.Add(add);
Console.WriteLine("Задача добавлена");

Console.Write("Задача для вставки: ");
string newAdd = Console.ReadLine() ?? "";

Console.Write("Индекс вставки: ");
int newIndex = Convert.ToInt32(Console.ReadLine());

if (!InsertTaskSafe(tasks, newIndex, newAdd))
{
    Console.WriteLine("Недопустимый индекс вставки");
}
else
{
    Console.WriteLine("Задача вставлена");
}

Console.Write("Название задачи для удаления: ");
string zadaca = Console.ReadLine() ?? "";

if (tasks.Remove(zadaca))
{
    System.Console.WriteLine("Первое совпадение удалено ");
}
else
{
    System.Console.WriteLine("Задача не найдена");
}

Console.Write("Назовите индекс задачи для удаления: ");
int newIndexx = Convert.ToInt32(Console.ReadLine());

if (RemoveTaskAtSafe(tasks, newIndexx))
{
    System.Console.WriteLine("Задача по индексу удалена");
}
else
{
    System.Console.WriteLine("Недопустимый индекс удаления");
}

Console.Write("Назовите название задачи для поиска: ");
string poisk = Console.ReadLine() ?? "";
int found = tasks.IndexOf(poisk);

if (found >= 0)
{
    System.Console.WriteLine($"Первый индекс: {found}");
}
else
{
    System.Console.WriteLine("Задача не найдена");
}

Console.WriteLine(">>> Итоговый список дел <<<");
Console.WriteLine();
Console.WriteLine($"Количество задач: {tasks.Count}");
PrintTasks(tasks);


Console.WriteLine();
Console.WriteLine("Вариант 1");

Console.Write("Введите название задачи для поиска: ");
string searchTitle = Console.ReadLine() ?? "";

int matches = CountTask(tasks, searchTitle);

Console.WriteLine($"Количество совпадений: {matches}");

int CountTask(List<string> tasks, string title)
{
    int count = 0;

    foreach (string task in tasks)
    {
        if (task == title)
        {
            count++;
        }
    }
    return count;
}