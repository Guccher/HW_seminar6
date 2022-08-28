// Задача №41

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input size: ");
// int size = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Input min: ");
// int min = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Input max: ");
// int max = int.Parse(Console.ReadLine() ?? "0");
// int count = 0;
// int[] array = CreateRandomArray(size, min, max);
// ShowArray(array);
// for (int i = 0; i < array.Length; i++)
// {
//  if (array[i] > 0)
//  {
//    count ++;
//  }

// }
// Console.WriteLine(count);


// Задача №43

// Console.Write("Input b1: ");
// double b1 = double.Parse(Console.ReadLine() ?? "0");
// Console.Write("Input k1: ");
// double k1 = double.Parse(Console.ReadLine() ?? "0");
// Console.Write("Input b2: ");
// double b2 = double.Parse(Console.ReadLine() ?? "0");
// Console.Write("Input k2: ");
// double k2 = double.Parse(Console.ReadLine() ?? "0");

// double x = ((b2-b1)/(k1-k2));
// double y = ((k1*x) + b1);
// Console.WriteLine($"x={x:f1}");
// Console.WriteLine($"y={y:f1}");


// Задача №42

// Console.Clear();
// Console.Write("Input number: ");
// double number = double.Parse(Console.ReadLine() ?? "0");
// double[] array = new double[8];
// array[0] = number;
// for (int i = 1; i < array.Length; i++)
// {
//     if (number >= 1)
//     {
//         array[i] = number / 2;
//         Console.Write(number + ", ");
//         number = number / 2;
//     }
//     else
//     {
//         array[i] = 0;
//     }
// }
// int[] array1 = new int[array.Length];

// for (int i = 0; i < array1.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         array1[i] = 0;
//     }
//     else
//     {
//         array1[i] = 1;
//     }

// }
// for (int i = 0; i < array1.Length / 2; i++)
// {
//     int temp = array1[i];
//     array1[i] = array1[array1.Length - 1 - i];
//     array1[array1.Length - 1 - i] = temp;
// }
// Console.WriteLine($"[{String.Join(", ", array1)}]");


// Задача №44

// Console.Write("Input number: ");
// int FibNumber = int.Parse(Console.ReadLine() ?? "0");
// int F0 = 0;
// int F1 = 1; 
// Console.WriteLine(0);
// while (FibNumber >= F0)
// {
//     F0 = F0 + F1;
//     F1 = F0 - F1;
//     FibNumber = FibNumber - 1;
//     Console.WriteLine(F0);
// }





