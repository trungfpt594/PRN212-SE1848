using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

void swap(ref int x, ref int y)
{
    int temp = x;
    x = y;
    y = temp;
}
void sort_array(int []arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length; j++)
        {
            if (arr[i] > arr[j])
            {
                swap(ref arr[i], ref arr[j]);
            }    
        }
    }
    int[] values = new int[10];
    void createArray(int[] values)
    {
        Random random = new Random();
        for (int i = 0; i < values.Length; i++)
        {
            Console.WriteLine("Nhap phan tu thu {0} = ", i);
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
    printArray(values);
}


