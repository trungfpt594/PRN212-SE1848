void swap(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}

void sort_array(int[] arr)
{
    int i = 0;
    do
    {
        int j = 0;
        do
        {
            if (arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }
            j++;
        } while (j < arr.Length);
        i++;
    } while (i < arr.Length);
}


int[] values = new int[10];

void createArray(int[] values)
{
    Random random = new Random();
    for (int i = 0; i < values.Length; i++)
    {
        Console.Write("Nhap phan tu thu {0} = ", i);
        values[i] = int.Parse(Console.ReadLine());
    }
}

void printArray(int[] values)
{
    Console.WriteLine("Cac phan tu trong mang la: ");
    foreach (int value in values)
        Console.Write(value + " ");
    Console.WriteLine();
}

createArray(values);
Console.WriteLine("\nMang truoc khi sap xep:");
printArray(values);

sort_array(values);
Console.WriteLine("\nMang sau khi sap xep giam dan:");
printArray(values);
