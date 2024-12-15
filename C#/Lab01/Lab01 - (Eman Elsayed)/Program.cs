namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region - array of 10 intergers and get min and max value   |5|4|2|-1|-33|55|66|77|88|100|
            #region - First Way traditional way
            //int[] arr = new int[10];
            //Console.WriteLine("Enter 10 numbers to get min & max");
            //for(int i =0;i < arr.Length; i++)
            //{
            //    Console.Write($"please Enter #{i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int min = arr[0] , max = arr[0];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > max)
            //        max = arr[i];


            //    if (arr[i] < min)
            //        min = arr[i];
            //}
            //Console.WriteLine($"Smallest number is {min} and Maximum number is {max}");
            #endregion
            #region - Second Way using build in function
            //int[] arr = new int[10];
            //Console.WriteLine("Enter 10 numbers to get min & max");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"please Enter #{i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int min = arr.Min();
            //int max = arr.Max();
            //Console.WriteLine($"The Smallest number is {min} and maximum is {max}");
            #endregion
            #region - Third way using sorting
            //int[] arr = new int[10];
            //Console.WriteLine("Enter 10 numbers to get min & max");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"please Enter #{i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Array.Sort(arr);
            //Console.WriteLine($"The smallest number is {arr[0]} and maximum number is {arr[9]}");
            #endregion
            #endregion

            #region - array of 10 integers and sort it ascending without any built in function
            #region Bubble Sort O(n ^ 2)
            //int[] arr = new int[10];
            //Console.WriteLine("Enter 10 numbers to sort using Bubble Sort");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"please Enter #{i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i =0;i < arr.Length; i++)
            //{
            //    for(int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] > arr[j])
            //        {
            //            int temp = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temp;
            //        }
            //    }
            //}
            //Console.WriteLine("Bubble Sort: ");
            //for(int i =0;i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]}\t");
            //}
            #endregion
            #region Selection Sort O(n ^ 2)
            //int[] arr = new int[10];
            //Console.WriteLine("Enter 10 numbers to sort using Selection Sort");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"please Enter #{i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int minIndex = i;
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[j] < arr[minIndex])
            //        {
            //            minIndex = j;
            //        }
            //    }
            //    int temp = arr[minIndex];
            //    arr[minIndex] = arr[i];
            //    arr[i] = temp;
            //}
            //Console.WriteLine("Selection Sort: ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]}\t");
            //}
            #endregion
            #region  Insertion Sort O(n ^ 2)
            //int[] arr = new int[10];
            //Console.WriteLine("Enter 10 numbers to sort using insertion Sort");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"please Enter #{i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Insertion Sort");
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    int ele = arr[i];
            //    int j = i - 1;
            //    while (j >= 0 && arr[j] > ele)
            //    {
            //        arr[j + 1] = arr[j];
            //        j--;
            //    }
            //    arr[j + 1] = ele;
            //}
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]}\t");
            //}
            #endregion
            #region Merge Sort O(n log n)
            //    int[] arr = new int[10];
            //    Console.WriteLine("Enter 10 numbers to sort using Merge Sort");
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.Write($"please Enter #{i + 1}: ");
            //        arr[i] = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine("Merge Sort");
            //    MergeSort(arr);
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        Console.Write($"{arr[i]}\t");
            //    }
            //}
            //static public void MergeSort(int[] arr)
            //{
            //    if (arr.Length <= 1) return;

            //    int mid = arr.Length / 2;
            //    int[] left = new int[mid];
            //    int[] right = new int[arr.Length - mid];
            //    Array.Copy(arr, 0, left, 0, mid);
            //    Array.Copy(arr, mid, right, 0, arr.Length - mid);

            //    MergeSort(left);
            //    MergeSort(right);
            //    Merge(arr, left, right);
            //}
            //static void Merge(int[] arr, int[] left, int[] right)
            //{
            //    int i = 0, j = 0, k = 0;
            //    while (i < left.Length && j < right.Length)
            //    {
            //        if (left[i] < right[j])
            //            arr[k++] = left[i++];
            //        else
            //            arr[k++] = right[j++];
            //    }
            //    while (i < left.Length)
            //        arr[k++] = left[i++];
            //    while (j < right.Length)
            //        arr[k++] = right[j++];
            //}
            #endregion
            #endregion

            #region - array of 10 integers and search number and get index
            #region Solve using Sequential Search (Linear - O(n))
            //int[] arr = new int[10];
            //Console.WriteLine("Enter numbers in your Array: ");
            //for(int i =0;i < arr.Length; i++)
            //{
            //    Console.Write($"Enter #{i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.Write("Enter number you need to search: ");
            //int number = int.Parse(Console.ReadLine());

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == number)
            //    {
            //        Console.WriteLine($"Found at {i + 1}");
            //        return;
            //    }
            //}
            //Console.WriteLine("NotFound");
            #endregion
            #region Solve using Binary Search O(log n)
            //int[] arr = new int[10];
            //Console.WriteLine("Enter numbers in your Array: ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter #{i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //Console.Write("Enter number you need to search: ");
            //int number = int.Parse(Console.ReadLine());
            //Array.Sort(arr);
            //int l = 0, r = arr.Length - 1;
            //while(l <= r)
            //{
            //    int mid = l + (r - l) / 2;
            //    if (arr[mid] == number)
            //    {
            //        Console.WriteLine($"Number found at index {mid + 1}");
            //        return;
            //    }
            //    else if (arr[mid] > number)
            //    {
            //        r = mid - 1;
            //    }
            //    else
            //    {
            //        l = mid + 1;
            //    }
            //}
            //Console.WriteLine("NotFound");

            #endregion
            #region Using Hashing O(n)
            //int[] arr = new int[10];
            //Dictionary<int , int> hashTable = new Dictionary<int , int>();
            //Console.WriteLine("Enter numbers in your Array: ");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.Write($"Enter #{i + 1}: ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //    if (hashTable.ContainsKey(arr[i]))
            //        continue;
            //    hashTable[arr[i]] = i + 1;
            //}
            //Console.Write("Enter number you need to search: ");
            //int number = int.Parse(Console.ReadLine());
            //if(hashTable.ContainsKey(number))
            //Console.WriteLine($"Found at {hashTable[number]}");
            //else
            //    Console.WriteLine("NotFound");
            #endregion
            #endregion

            #region - multiplication matrix  3*2   *  2*1   =3*1
            //int[,] mat1 = new int[3, 2];
            //int[,] mat2 = new int[2, 1];
            //Console.WriteLine("First Enter Input Matrix one: ");
            //for(int i = 0; i < mat1.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter elements of row #{i+1}");
            //    for(int j = 0; j < mat1.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter elements of row #{i + 1} col {j + 1}");
            //        mat1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Nice , Second Enter Input Matrix Two: ");
            //for (int i = 0; i < mat2.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter elements of row #{i + 1}");
            //    for (int j = 0; j < mat2.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter elements of row #{i + 1} col {j + 1}");
            //        mat2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //int[] ansMat = new int[3];
            //for (int i = 0; i < mat1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mat1.GetLength(1); j++)
            //    {
            //        ansMat[i] += mat1[i, j] * mat2[j, 0];
            //    }
            //}
            //  Console.WriteLine("Result Matrix: ");
            //for (int i = 0; i < ansMat.Length; i++)
            //{
            //    Console.WriteLine($"{ansMat[i]}\n");
            //}
            #endregion

            #region - Bonus Multiplication Matrix 3*3   * 3*2    = 3*2
            //int[,] mat1 = new int[3, 3];
            //int[,] mat2 = new int[3, 2];
            //Console.WriteLine("First Enter Input Matrix one: ");
            //for (int i = 0; i < mat1.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter elements of row #{i + 1}");
            //    for (int j = 0; j < mat1.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter elements of row #{i + 1} col {j + 1}");
            //        mat1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Console.WriteLine("Nice , Second Enter Input Matrix Two: ");
            //for (int i = 0; i < mat2.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Enter elements of row #{i + 1}");
            //    for (int j = 0; j < mat2.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter elements of row #{i + 1} col {j + 1}");
            //        mat2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //int[,] ansMat = new int[3 , 2];
            //for (int i = 0; i < mat1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < mat2.GetLength(1); j++)
            //    {
            //      for(int k = 0; k < mat1.GetLength(1); k++)
            //        {
            //            ansMat[i, j] += mat1[i, k] * mat2[k, j];
            //        }
            //    }
            //}
            //Console.WriteLine("Result Matrix: ");
            //for(int i = 0; i < ansMat.GetLength(0); i++)
            //{
            //    for(int j = 0; j < ansMat.GetLength(1); j++)
            //    {
            //        Console.Write(ansMat[i , j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region calculate your birth date
            Console.WriteLine("Welcome at Age Calculator: ");
            char charContinue;
            do
            {
                int currentday = DateTime.Now.Day;
                int currentmonth = DateTime.Now.Month;
                int currentyear = DateTime.Now.Year;
                int userBirthday;
                int userMonth;
                int userYear;
                int maxDay;
                do
                {
                    Console.WriteLine("Plz Enter the Year you born (1980 - 2023)");
                    userYear = int.Parse(Console.ReadLine());
                } while (userYear < 1980 || userYear > 2023);

                do
                {
                    Console.WriteLine("Plz Enter the Month you born (1 - 12)");
                    userMonth = int.Parse(Console.ReadLine());
                } while (userMonth < 1 || userMonth > 12);

                do
                {
                    maxDay = MaxDayCal(userMonth, userYear);
                    Console.WriteLine($"Plz Enter the Day you born (1 - {maxDay})");
                    userBirthday = int.Parse(Console.ReadLine());
                } while (userBirthday < 1 || userBirthday > maxDay);
                int ageDays = currentday - userBirthday;
                if (ageDays < 0)
                {
                    ageDays += MaxDayCal(currentmonth, currentyear);
                    currentmonth--;
                }
                int ageMonth = currentmonth - userMonth;
                if (ageMonth < 0)
                {
                    currentyear--;
                    ageMonth += 12;
                }
                int ageYear = currentyear - userYear;
                Console.WriteLine($"You are {ageYear} year , {ageMonth} Month , {ageDays} Days");
                Console.Write("Do You Want To repeat the age calculation Again (Y/N): ");
                charContinue = char.ToLower(char.Parse(Console.ReadLine()));
            } while (charContinue != 'y');

            #endregion

            #region simple calculator
            //char charContinue = 'y';
            //do
            //{
            //    Console.WriteLine("Enter #1: ");
            //    double num1 = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter #2: ");
            //    double num2 = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter operator (+, -, *, /): ");
            //    char operation = char.Parse(Console.ReadLine());

            //    double result = 0;

            //    switch (operation)
            //    {
            //        case '+':
            //            result = num1 + num2;
            //            break;
            //        case '-':
            //            result = num1 - num2;
            //            break;
            //        case '*':
            //            result = num1 * num2;
            //            break;
            //        case '/':
            //            if (num2 != 0)
            //                result = num1 / num2;
            //            else
            //            {
            //                Console.WriteLine("Error: Division by zero is not allowed.");
            //                continue;
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("Invalid operator. This should not happen due to validation.");
            //            continue;
            //    }

            //    Console.WriteLine($"{num1} {operation} {num2} = {result}");

            //    Console.WriteLine("Continue? (y or n): ");
            //    charContinue = char.ToLower(char.Parse( Console.ReadLine()));
            //    Console.WriteLine(); 
            //} while (charContinue != 'n');
            #endregion
        }
        static int MaxDayCal(int month , int year)
        {
            if(month == 1 || month == 3  || month == 5 || month == 7 || month == 8 || month == 10 || month == 12 )
            {
                return 31;
            }
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }
            else
            {
                return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0)) ? 29 : 28;
            }
        }
    }
}
