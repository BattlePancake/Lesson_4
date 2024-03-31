// -----------------------Task 1---------------------------------------
// int[] arr1 = {1,2,3,4,5,6};
// Console.WriteLine("Enter your number: ");
// int num = int.Parse(Console.ReadLine());
// foreach(int a in arr1)
// {
//     if(num == a)
//     {
//         Console.Write($"Number {num} is in array.");
//         return;
//     }
// }
// Console.Write($"Number {num} is NOT in array.");


// -----------------------Task 2---------------------------------------
// int[] arr = {1,2,3,4,5,1,2,3,4,5,1,2,3,4,5};
// Console.WriteLine("Enter your number: ");
// int num = int.Parse(Console.ReadLine());
// int success = 0;
// for(int a = 0; a < arr.Length; a++)
// {
//     if(num == arr[a])
//     {
//         success = 1;
//         Console.Write($"Number {num} is in array.");
//         break;
//     }
// }
// if(success == 0)
// {
//     Console.Write($"Number {num} is NOT in array.");
// }
// Console.WriteLine("\nNew array is: ");
// for(int a = 0; a < arr.Length; a++)
// {
//     if(num != arr[a])
//     {
//         Console.Write($"{arr[a]} ");
//     }
// }


// -----------------------Task 3---------------------------------------
// Console.WriteLine("Enter array length: ");
// int arrAmount = int.Parse(Console.ReadLine());
// int[] arr = new int[arrAmount];
// for(int a = 0; a < arrAmount; a++)
// {
//     arr[a] = Random.Shared.Next(1,9);
//     Console.Write($"{arr[a]} ");
// }
// int max = 0;
// foreach(int b in arr)
// {
//     if (max < b)
//     {
//         max = b;
//     }
// }
// Console.WriteLine($"\nMax array number is: {max}");
// int min = arr[0];
// foreach(int c in arr)
// {
//     if (min > c)
//     {
//         min = c;
//     }
// }
// Console.WriteLine($"Min array number is: {min}");
// int sum = 0;
// foreach(int c in arr)
// {
//     sum += c;
// }
// int med = sum / arrAmount;
// Console.WriteLine($"Average array number is: {med}");


// -----------------------Task 4---------------------------------------

// int[] arr2 = {1,2,3,4,5};
// int[] arr = {6,7,8,9,10};
// foreach(int a in arr)
// {
//         Console.Write($"{a} ");
// }
// Console.WriteLine();
// foreach(int b in arr2)
// {
//         Console.Write($"{b} ");
// }

// int sum1 = 0;
// foreach(int c in arr)
// {
//     sum1 += c;
// }
// int med1 = sum1 / arr.Length;
// int sum2 = 0;
// foreach(int d in arr2)
// {
//     sum2 += d;
// }
// int med2 = sum2 / arr2.Length;
// Console.WriteLine();

// if(med1 > med2)
// {
//     Console.Write($"Average number of array 1 is bigger: {med1} vs {med2}");
// }
// else if (med1 < med2)
// {
//     Console.Write($"Average number of array 2 is bigger: {med2} vs {med1}");
// }
// else
// {
//     Console.Write($"Average numbers of both arrays are equal: {med1} = {med2}");
// }


// -------------Additional Task 4---------------------------------------
// Console.WriteLine("Enter array length: ");
// int arrLen = int.Parse(Console.ReadLine());
//     while(arrLen <= 5 || arrLen > 10)
//     {
//         Console.WriteLine("Invalid length, please, try again: ");
//         arrLen = int.Parse(Console.ReadLine());
//     }
// int[] arr = new int[arrLen];
// for(int a = 0; a < arrLen; a++)
// {
//     arr[a] = Random.Shared.Next(1,9);
//     Console.Write($"{arr[a]} ");
// }
// Console.WriteLine();
// int[] arr1 = new int[arrLen];
// for(int b = 0; b < arrLen; b++)
// {
//     if(arr[b] % 2 == 0)
//     {
//         arr1[b] = arr[b];
//         Console.Write($"{arr1[b]} ");
//     }
// }


// -------------Additional Task 5---------------------------------------
// Console.WriteLine("Enter array length: ");
// int arrLen = int.Parse(Console.ReadLine());
// int[] arr = new int[arrLen];
// for(int a = 0; a < arr.Length; a++)
// {
//     arr[a] = Random.Shared.Next(1,9);
//     Console.Write($"{arr[a]} ");
// }
// for(int a = 1; a < arr.Length; a += 2)
// {
//     arr[a] = 0;
// }
// Console.WriteLine();
// for(int a = 0; a < arr.Length; a++)
// {
//     Console.Write($"{arr[a]} ");
// }


// -------------Additional Task 6 & 7---------------------------------------
// string[] names = {"Bella", "Albert", "james", "Nick", "Paul", "boris", "Kate", "will","Anton"};

// for(int a = 0; a < names.Length - 1; a++)
// {
//     for(int b = a + 1; b < names.Length; b++)
//         {
//           int result = string.Compare(names[a],names[b],StringComparison.OrdinalIgnoreCase);
//           if (result > 0)
//            {
//               string temp = names[a];
//               names[a] = names[b];
//               names[b] = temp;
//             }
//         }
// }
// for(int c = 0; c < names.Length; c++)
// {
//     Console.Write($"{names[c]} ");
// }


// -------------Additional Task 8---------------------------------------
// int[,] oldArr1 = {{1,0,0,0},{0,1,0,0},{0,0,0,0}};
// int[,] oldArr2 = {{1,2,3},{1,1,1},{0,0,0},{2,1,0}};

// int[,] newArr1 = new int[3,3];
// for(int a = 0; a < oldArr1.GetLength(0); a++)
// {
//     for(int b = 0; b < newArr1.GetLength(1); b++)
//         {
//             newArr1[a,b] = oldArr1[a,b];
//             Console.Write($"{newArr1[a,b]} ");
//         }
//         Console.WriteLine();
// }
// Console.WriteLine();
// int[,] newArr2 = new int[3,3];
// for(int c = 0; c < oldArr2.GetLength(0) - 1; c++)
// {
//     for(int d = 0; d < newArr2.GetLength(1); d++)
//         {
//             newArr2[c,d] = oldArr2[c,d];
//             Console.Write($"{newArr2[c,d]} ");
//         }
//         Console.WriteLine();
// }
// Console.WriteLine();
// int[,] newArr3 = new int[3,3];
// for(int e = 0; e < newArr3.GetLength(0); e++)
// {
//     for(int f = 0; f < newArr3.GetLength(1); f++)
//         {
//             for(int g = 0; g < newArr3.GetLength(1); g++)
//             {
//                 newArr3[e,f] += newArr1[e,g] * newArr2[g,f];
//             }
//         }
// }
// for(int c = 0; c < oldArr2.GetLength(0) - 1; c++)
// {
//     for(int d = 0; d < newArr2.GetLength(1); d++)
//         {
//             Console.Write($"{newArr2[c,d]} ");
//         }
//         Console.WriteLine();
// }


// -------------Additional Task 9---------------------------------------
// int[,] arr1 = {{1,2,3},{1,1,1},{0,0,0},{2,1,0}};

// int sum = 0;
// for(int a = 0; a < arr1.GetLength(0); a++)
// {
//     for(int b = 0; b < arr1.GetLength(1); b++)
//         {
//             sum += arr1[a,b];
//         }
// }
// Console.WriteLine(sum);


// -------------Additional Task 10---------------------------------------
// int[,] arr1 = {{1,2,3,4},{5,6,7,8},{9,10,11,12},{13,14,15,16}};
// for(int a = 0; a < arr1.GetLength(0); a++)
// {
//     for(int b = 0; b < arr1.GetLength(1); b++)
//         {
//             Console.Write($"{arr1[a,b]} ");
//         }
//         Console.WriteLine();
// }

// Console.WriteLine("\n");
// for(int c = 0; c < arr1.GetLength(0); c++)
// {
//     Console.Write($"{arr1[c,c]} ");
// }
// Console.WriteLine("\n\n");
// for(int a = 3; a >= 0; a--)
// {
//     for(int b = 0; b < arr1.GetLength(1); b++)
//         {
//             if(a == arr1.GetLength(0) - 1 && b == 0)
//             {
//                 Console.Write($"{arr1[a,b]} ");
//             }
//             else if(a == arr1.GetLength(0) - 2 && b == arr1.GetLength(0) - 3)
//             {
//                 Console.Write($"{arr1[a,b]} ");
//             }
//             else if(a == arr1.GetLength(0) - 3 && b == arr1.GetLength(0) - 2)
//             {
//                 Console.Write($"{arr1[a,b]} ");
//             }
//             else if(a == 0 && b == arr1.GetLength(0) - 1)
//             {
//                 Console.Write($"{arr1[a,b]} ");
//             }
//         }
// }


// -------------Additional Task 11---------------------------------------

// -------------Way1-----------------------------------------------------
// int[,] arr2 = {{9,2,4,3,5,6,7,8,1},{10,15,14,16,11,13,12,18,17}};

// int[] arr3 = new int[arr2.GetLength(1)];
// int[] arr4 = new int[arr2.GetLength(1)];

// for(int a = 0; a < arr2.GetLength(0) - 1; a++)
// {
//     for(int b = 0; b < arr2.GetLength(1); b++)
//         {
//             arr3[b] = arr2[a,b];
//         }
// }
// for(int a = 1; a < arr2.GetLength(0); a++)
// {
//     for(int b = 0; b < arr2.GetLength(1); b++)
//         {
//             arr4[b] = arr2[a,b];
//         }
// }

// for(int a = 0; a < arr3.Length; a++)
// {
//     for(int b = a + 1; b < arr3.Length; b++)
//         {
//             if (arr3[a] > arr3[b])
//               {
//                 int temp = arr3[b];
//                 arr3[b] = arr3[a];
//                 arr3[a] = temp;
//                }
//         }
// }
// for(int a = 0; a < arr4.Length; a++)
// {
//     for(int b = a + 1; b < arr4.Length; b++)
//         {
//             if (arr4[a] > arr4[b])
//               {
//                 int temp = arr4[b];
//                 arr4[b] = arr4[a];
//                 arr4[a] = temp;
//                }
//         }
// }

// for(int a = 0; a < arr2.GetLength(0) - 1; a++)
// {
//     for(int b = 0; b < arr2.GetLength(1); b++)
//         {
//             arr2[a,b] = arr3[b];
//         }
// }
// for(int a = 1; a < arr2.GetLength(0); a++)
// {
//     for(int b = 0; b < arr2.GetLength(1); b++)
//         {
//             arr2[a,b] = arr4[b];
//         }
// }

// for(int a = 0; a < arr2.GetLength(0); a++)
// {
//     for(int b = 0; b < arr2.GetLength(1); b++)
//         {
//             Console.Write($"{arr2[a,b]} ");
//         }
//     Console.WriteLine();
// }


// -------------Way2-----------------------------------------------------

// int[,] arr5 = {{9,2,4,3,5,6,7,8,1},{10,15,14,16,11,13,12,18,17}};

// for(int a = 0; a < 1; a++)
// {   
//     for (int z = 0; z < arr5.GetLength(1)-1; z++)
//     {
//         for(int b = z + 1; b < arr5.GetLength(1); b++)
//         {
//             if (arr5[a,z] > arr5[a,b])
//                 {
//                     int temp = arr5[a,b];
//                     arr5[a,b] = arr5[a,z];
//                     arr5[a,z] = temp;
//                 }
//         }
//     }
// }
// for(int a = 1; a < 2; a++)
// {   
//     for (int z = 0; z < arr5.GetLength(1)-1; z++)
//     {
//         for(int b = z + 1; b < arr5.GetLength(1); b++)
//         {
//             if (arr5[a,z] > arr5[a,b])
//                 {
//                     int temp = arr5[a,b];
//                     arr5[a,b] = arr5[a,z];
//                     arr5[a,z] = temp;
//                 }
//         }
//     }
// }
// for(int a = 0; a < arr5.GetLength(0); a++)
// {
//     for(int b = 0; b < arr5.GetLength(1); b++)
//         {
//             Console.Write($"{arr5[a,b]} ");
//         }
//     Console.WriteLine();
// }