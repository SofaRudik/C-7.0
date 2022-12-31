Console.Clear();
Console.Write("Введите размер матрицы: ");
string[]coord=Console.ReadLine().Split(" ");
int row=int.Parse(coord[0]);
int column=int.Parse(coord[1]);
int[,] matrix=new int [row,column];
InputMatrix(matrix);

Console.Write("Введите номер строки: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int m=Convert.ToInt32(Console.ReadLine());
Relaese(matrix);

void InputMatrix (int[,]matrix)
{
    for(int i=0; i<matrix.GetLength(0);i++)
    {
        for(int j=0; j<matrix.GetLength(1);j++)
        {
            matrix[i,j]= new Random().Next(-10,11);
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}
void Relaese (int[,]matrix)
{
     if(n>matrix.GetLength(0) || m>matrix.GetLength(1)) 
        Console.WriteLine("такого элемента нет");
        else Console.WriteLine($"{matrix[n-1,m-1]}");
}