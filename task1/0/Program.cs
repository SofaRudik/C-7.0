Console.Clear();
Console.Write("Введите размер матрицы: ");
string[]coord=Console.ReadLine().Split(" ");
int row=int.Parse(coord[0]);
int column=int.Parse(coord[0]);
double[,] matrix=new double [row,column];
InputMatrix(matrix);

void InputMatrix (double[,]matrix)
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