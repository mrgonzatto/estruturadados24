// See https://aka.ms/new-console-template for more information
Console.WriteLine("Testando o Quick Sort");

int[] values = new int[] {0, 15, 24, 1, 3, 6, 12, 9};

QuickSort.QuickSort.Print<int>(values);
Console.WriteLine("Iniciando ordenação.");
QuickSort.QuickSort.Sort<int>(values, 0, values.Length - 1 );
Console.WriteLine("Finzando ordenação.");
QuickSort.QuickSort.Print<int>(values);
