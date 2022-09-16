// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


bool PalindromChecker(string num)
{
    for (int i = 0; i < num.Length / 2; ++i)
        if (num[i] != num[num.Length - 1 - i])
        return false;
        return true;
}


Console.WriteLine("Введите число для проверки на палиндром: ");

int num = 0;
try
    {
        num = Convert.ToInt32(Console.ReadLine());
    }
catch
    {    
        Console.WriteLine("Нужно вводить целое число!");
    }



// По условию задачи число пятизначное. По этой причине вводится проверка на соответствие целому

// Проверка числа на палиндром происходит через преобразование в строку.
// Данный метод позволяет проверять строки из символов.


string number = Convert.ToString(num);

if (PalindromChecker(number)==false)
    {
        Console.WriteLine("Введённое число не является палиндромом");
    }
    else
    {
        Console.WriteLine("Введённое число палиндром");
    }
