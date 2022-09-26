// двумерные массивы
string[,] table = new string[2,5]; // строка, столбец
// table [0,0] table [0,1] table [0,2] table [0,3] table [0,4]
// table [1,0] table [1,1] table [1,2] table [1,3] table [1,4]

table[1, 3] = "данные 1 строки 3 столбца";

for(int rows = 0; rows < 2; rows++)
{
    for (int colums = 0; colums < 5; colums++)
    {
        Console.Write($"-{table[rows, colums]}-");
    }
}

int[,] matrix = new int[3,4];

void PrintArray(int[,] matr)
{
    for(int rows = 0; rows < 3; rows++) // вместо 3 можно указывать GetLength(0) - будет передавать количество строк
    {
        Console.WriteLine(); // пишем с новой строки
        for(int colums = 0; colums < 4; colums++) // вместо 4 можно указывать GetLength(1)
                                                  // - будет передавать количество столбцов {
        {
            Console.Write($"{matrix[rows, colums]} ");
        }
    }
}

void FillArray(int[,] matr)
{
    for(int i = 0; i < matr.GetLength(0); i++)
    {
        for(int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(0,10);
        }
    }
}

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
