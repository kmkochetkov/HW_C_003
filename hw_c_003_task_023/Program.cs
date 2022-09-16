// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


double Cube(int num)
{
    return Math.Pow(num,3);
}

// Очистка консоли
Console.Clear();

// Приглашение пользователя для ввода числа:
Console.Write(" Введите число N: ");

// Ввод данных и проверка введённых данных

int number = 0;

try
    {
        number = Convert.ToInt32(Console.ReadLine());
    }
catch
    {    
        Console.WriteLine("Вводите, пожалуйста, целое число");
    }


//Очистка консоли
Console.Clear();

Console.WriteLine($"| Кубы чисел 1..{number}: |");
Console.WriteLine("-----------------");

// Вывод таблицы кубов
for (int i=1; i <= number; i++)
    Console.WriteLine($"| {i} : {Cube(i)}");
    


