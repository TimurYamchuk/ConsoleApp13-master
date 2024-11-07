using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Проверка фамилии и инициалов
        Console.WriteLine("Введите фамилию и инициалы (Иванов И.И. или Иванов ИИ):");
        string nameInput = Console.ReadLine();
        string namePattern = @"^[А-Я][а-я]+ [А-Я]\.[А-Я]\.$|^[А-Я][а-я]+ [А-Я]{2}$";

        if (Regex.IsMatch(nameInput, namePattern))
        {
            Console.WriteLine("Фамилия и инициалы введены корректно.");
        }
        else
        {
            Console.WriteLine("Некорректный формат. Используйте: Иванов И.И. или Иванов ИИ");
        }

        // Проверка адреса электронной почты
        Console.WriteLine("Введите адрес электронной почты:");
        string emailInput = Console.ReadLine();
        string emailPattern = @"^[A-Za-z][A-Za-z0-9_]{2,15}@[A-Za-z0-9]+(\.[A-Za-z0-9]+)*\.[A-Za-z]{2,3}$";

        if (Regex.IsMatch(emailInput, emailPattern))
        {
            Console.WriteLine("Адрес электронной почты введен корректно.");
        }
        else
        {
            Console.WriteLine("Некорректный формат адреса электронной почты.");
        }

        // Проверка даты
        Console.WriteLine("Введите дату в формате ДД-ММ-ГГГГ (например, 01-04-2015):");
        string dateInput = Console.ReadLine();
        string datePattern = @"^(0[1-9]|[12][0-9]|3[01])-(0[1-9]|1[0-2])-(\d{4})$";

        if (Regex.IsMatch(dateInput, datePattern))
        {
            Console.WriteLine("Дата введена корректно.");
        }
        else
        {
            Console.WriteLine("Некорректный формат даты. Используйте: ДД-ММ-ГГГГ");
        }
    }
}
