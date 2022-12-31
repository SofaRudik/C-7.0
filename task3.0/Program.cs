Console.Clear();
Console.Write("Введите размер матрицы: ");
string[]coord=Console.ReadLine().Split(" ");
int row=int.Parse(coord[0]);
int column=int.Parse(coord[1]);
int[,] matrix=new int [row,column];
InputMatrix(matrix);
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
{ for(int i=0; i<matrix.GetLength(0);i++)
    { double sum=0;
        for(int j=0; j<matrix.GetLength(1);j++)
    {
        sum+=matrix[j,i];
    } 
Console.WriteLine($"Результат по {i} столбцу={sum/matrix.GetLength(1)}");}
}