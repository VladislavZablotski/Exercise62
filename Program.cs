int[,] array = new int[4,8];
int HelixPass = 0;
int Counter = 11;
int Row = 0;
int Column = 0;

while (Counter <= array.GetLength(0)*array.GetLength(1)-1+10)
{
    while (Column < array.GetLength(1)-1-HelixPass)
    {
        array[Row,Column] = Counter;
        Column++;
        Counter++;
    }
    while (Row < array.GetLength(0)-1-HelixPass)
    {
        array[Row,Column] = Counter;
        Row++;
        Counter++;
    }
    while (Column > HelixPass)
    {
        array[Row,Column] = Counter;
        Column--;
        Counter++;
    }
    HelixPass++;
    while (Row > HelixPass)
    {
        array[Row,Column] = Counter;
        Row--;
        Counter++;
    }
}
array[Row,Column] = Counter;
Console.WriteLine();
Console.WriteLine("Массив: ");
for (int i = 0; i < array.GetLength(0); i++)
{
   for (int j = 0; j < array.GetLength(1); j++)
   {
      Console.Write(array[i,j]+" ");
   }
   Console.WriteLine();
}