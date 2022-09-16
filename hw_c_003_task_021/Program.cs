// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


// Расчёт расстояния между координатами
double Distance3D(int[] point1, int[] point2)
{
    double distance=(Math.Sqrt((Math.Pow(point2[0],2))-(Math.Pow(point1[0],2))+(Math.Pow(point2[1],2))-(Math.Pow(point1[1],2))+(Math.Pow(point2[2],2))-(Math.Pow(point1[2],2))));
    return distance;
}

// Ввод значения координаты пользователем

int[] Coordinate3d()
{
    int[] coordinata = new int[3];
    for (int i = 0; i < 3; ++i)
        {
            coordinata[i] = 0;
            try
            {
                Console.Write($"Введите кординату {i+1}: ");
                coordinata[i] = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {    
                Console.WriteLine("Нужно вводить целое число!");
            }
        }
    return coordinata;
}


// Вывод координаты на консоль

int[] coord = new int[3];
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position]);
        position++;
    }
    Console.WriteLine("");    
}


// Ввод значения координат первой точки
Console.Clear();
Console.WriteLine("Первая точка: ");
int[] point1=Coordinate3d();

// Ввод значения координат второй точки
Console.WriteLine(""); 
Console.WriteLine("Вторая точка: ");
int[] point2=Coordinate3d();
Console.WriteLine("");

//Вывод значения воординат и расстояния между ними
Console.Clear();
Console.WriteLine("Координата первой точки: ");
PrintArray(point1);
Console.WriteLine("");
Console.WriteLine("Координата второй точки: ");
PrintArray(point2);
Console.WriteLine($"Расстояние между точками равно: {Distance3D(point1,point2)}");