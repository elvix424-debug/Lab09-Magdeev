// for (int number = 8; number >= 1; number--)
// {
//     Console.WriteLine($"Упражнение {number}");
// }

// Console.WriteLine("Домашнее задание готово");


// for(int room = 5; room <= 50; room += 5)
// {
//     Console.WriteLine($"Кабинет {room}");
// }


int totalWeeks = 3;

for (int week = 1; week <= totalWeeks; week++)
{
    Console.WriteLine("----------------");
    for(int day = 1; day <= 5; day++)
    {
        Console.WriteLine($"Неделя {week}, день {day}");
    }
}

// int count = 0;

// for (int ticket = 1; ticket <= 30; ticket++)
// {
//     if (ticket == 4 || ticket == 12 || ticket == 19)
//     {
//         count++;
//         continue;
//     }

//     Console.WriteLine($"Первый доступный билет: {ticket},  пропущено билетов до него: {count}");
//     break;
// }


// for (; ; )
// {
//     Console.WriteLine("Введите код группы (для выхода - <выход>):");
//     string groupCode = Console.ReadLine();
//     if (groupCode == "выход")
//     {
//         break;
//     }
//     Console.WriteLine($"Записан код группы: {groupCode}");
// }

// Console.WriteLine("Работа с журналом завершена");


//Самостоятельная работа
// //Задание А
// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine());
// for (int num = 1; num <= N; num += 2)
// {
//     Console.WriteLine($"Число {num}");
// }

// //Задание Г
// for(int num = 1; num <= 50; num++)
// {
//     if (num % 7 == 0) break;
//     if (num % 3 == 0) continue;
//     Console.WriteLine($"Число: {num}");
// }


// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");


//Вариант 4. Треугольникиз звёздочек
// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine());

// for (int i = 0; i <= N; i++)
// {
//     for (int j = 0; j < i; j++)
//     {
//         Console.WriteLine("*");
//     }
//     Console.WriteLine();
// }



//Вариант 9. Сумма без кратных пяти

// Console.Write("Введите число: ");
// int N = int.Parse(Console.ReadLine());
// int sum = 0;

// for (int i = 1; i <= N; i++)
// {
//     if (i % 5 == 0) continue;
//     sum += i;
// }
// Console.WriteLine($"Сумма всех чисел: {sum}");