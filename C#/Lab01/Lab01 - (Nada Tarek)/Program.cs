namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lab aasignment 1
            #region problem 1
            ////////////////////////////////////

            //int[] arr = new int[10] {5,4,2,-1,-33,55,66,88,99,7}

            //int min = 10000;
            //int max = -1;

            //for (int i = 0; i < arr.Length; i++) {

            //   if (arr[i] < min)
            //   {
            //       min = arr[i];
            //   }
            //   else if (arr[i] > max)
            //    {
            //       max = arr[i];
            //   }
            //}
            //Console.WriteLine($"Minimum number is: {min}");
            //Console.WriteLine($"Maximun number is: {max}");

            #endregion

            #region problem 2
            //////////////////////////

            //int[] arr = new int[5];
            //int temporary = 0;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine($"Enter a new number:");
            //    arr[i] = int.Parse(Console.ReadLine());

            //}

            //for (int i = 0; i < arr.Length - 1; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    { 
            //        if (arr[i] > arr[j])
            //        {
            //            temporary = arr[i];
            //            arr[i] = arr[j];
            //            arr[j] = temporary;
            //        }

            //    }
            //}

            //Console.WriteLine("Your sorted array is:");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion

            #region problem 3
            ////////////////////////////

            //int[] arr = new int[10] {4,5,6,7,8,9,2,3,66,77};
            //bool found = false;
            //int index = 0;

            //Console.WriteLine("Enter number to search:");
            //int search = int.Parse(Console.ReadLine());

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] == search)
            //    {
            //        found = true;
            //        index = i;
            //    }
            //    else if (arr[i] != search)
            //    {
            //        found = false;
            //    }
            //}

            //if (found == true)
            //{
            //    Console.WriteLine($"The number found at index : {index}");
            //}
            //else
            //{
            //    Console.WriteLine("Not Found");
            //}
            #endregion

            #region problem 4
            /////////////////////////////////////

            //int[,] arr1 = new int[3, 2];
            //int[,] arr2 = new int[2, 1];
            //int[,] arr3 = new int[3, 1];

            ////Fill First matrix
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter a number at index {i},{j} to fill the first matrix: ");
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            ////Fill Second matrix
            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter a number at index {i},{j} to fill the second matrix: ");
            //        arr2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            ////Multiply the two metrices
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < arr1.GetLength(1); k++)
            //        {
            //            arr3[i, j] += arr1[i, k] * arr2[k, j];
            //        }
            //    }
            //}

            //for (int i = 0; i < arr3.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr3.GetLength(1); j++)
            //    {
            //        Console.Write($"{arr3[i, j]}\t");
            //    }
            //}
            #endregion

            #region BOUNS
            ////////////////////////////

            //int[,] arr1 = new int[3, 3];
            //int[,] arr2 = new int[3, 2];
            //int[,] arr3 = new int[3, 2];

            //Fill First matrix
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter a number at index {i},{j} to fill the first matrix: ");
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            ////Fill Second matrix
            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter a number at index {i},{j} to fill the second matrix: ");
            //        arr2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            ////Multiply the two metrices
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        for (int k = 0; k < arr1.GetLength(1); k++)
            //        {
            //            arr3[i, j] += arr1[i, k] * arr2[k, j];
            //        }
            //    }
            //}

            //for (int i = 0; i < arr3.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr3.GetLength(1); j++)
            //    {
            //        Console.Write($"{arr3[i, j]}\t");
            //    }
            //}
            #endregion

            #region problem 5
            //////////////////////////////////

            //int[,] arr1 = new int[3, 4];
            //int[] arr2 = new int[4];
            //int[] sumOfcolumns = new int[arr1.GetLength(1)];

            ////Fill the table
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"Enter a number at index {i},{j} to fill the first matrix: ");
            //        arr1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            ////Get sums of each columns
            //for (int i = 0; i < arr1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr1.GetLength(1); j++)
            //    {
            //        sumOfcolumns[j] += arr1[i, j];
            //    }
            //}

            ////Get the average of each columns and print them
            //for (int i = 0; i < sumOfcolumns.Length; i++)
            //{
            //    Console.WriteLine($"The average of each columns is: {arr2[i] = sumOfcolumns[i] / 3}");
            //}
            #endregion

            #region problem 6
            /////////////////////////////

            //Console.WriteLine("Enter a year between 1980 and 2024: ");
            //int year = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a month: ");
            //int month = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter a day: ");
            //int day = int.Parse(Console.ReadLine());

            //DateTime today = DateTime.Now;

            //int current_year = today.Year;
            //int current_month = today.Month;
            //int current_day = today.Day;

            //int y = 0, m = 0, d = 0;

            //if (year >= 1980 && year <= 2024)
            //{
            //    if (year % 4 == 0) // checking for leap years
            //    {
            //        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            //        {
            //            if (day >= 1 && day <= 31)
            //            {
            //                if (day < current_day)
            //                {
            //                    d = current_day - day;

            //                    if (month < current_month)
            //                    {
            //                        m = current_month - month;
            //                    }
            //                    else if (month > current_month)
            //                    {
            //                        current_month = current_month + 12;
            //                        m = current_month - month;
            //                        current_year--;
            //                    }
            //                    y = current_year - year;
            //                }
            //                else
            //                {
            //                    day = day + 31;
            //                    month--;
            //                    if (month < current_month)
            //                    {
            //                        m = current_month - month;
            //                    }
            //                    else if (month > current_month)
            //                    {
            //                        month = month + 12;
            //                        m = current_month - month;
            //                        year--;
            //                    }
            //                    y = current_year - year;
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Enter right day!");
            //            }
            //        }
            //        else if (month == 4 || month == 6 || month == 9 || month == 11)
            //        {
            //            if (day >= 1 && day <= 30)
            //            {
            //                if (day < current_day)
            //                {
            //                    d = current_day - day;

            //                    if (month < current_month)
            //                    {
            //                        m = current_month - month;
            //                    }
            //                    else if (month > current_month)
            //                    {
            //                        current_month = current_month + 12;
            //                        m = current_month - month;
            //                        current_year--;
            //                    }
            //                    y = current_year - year;
            //                }
            //                else
            //                {
            //                    day = day + 30;
            //                    month--;
            //                    if (month < current_month)
            //                    {
            //                        m = current_month - month;
            //                    }
            //                    else if (month > current_month)
            //                    {
            //                        month = month + 12;
            //                        m = current_month - month;
            //                        year--;
            //                    }
            //                    y = current_year - year;
            //                }
            //            }
            //            else
            //            {

            //                Console.WriteLine("Enter right day!");
            //            }
            //        }
            //        else if (month == 2)
            //        {
            //            if (day >= 1 && day <= 29)
            //            {
            //                if (day < current_day)
            //                {
            //                    d = current_day - day;

            //                    if (month < current_month)
            //                    {
            //                        m = current_month - month;
            //                    }
            //                    else if (month > current_month)
            //                    {
            //                        current_month = current_month + 12;
            //                        m = current_month - month;
            //                        current_year--;
            //                    }
            //                    y = current_year - year;
            //                }
            //                else
            //                {
            //                    day = day + 30;
            //                    month--;
            //                    if (month < current_month)
            //                    {
            //                        m = current_month - month;
            //                    }
            //                    else if (month > current_month)
            //                    {
            //                        current_month = current_month + 12;
            //                        m = current_month - month;
            //                        current_year--;
            //                    }
            //                    y = current_year - year;
            //                }
            //            }
            //            else
            //                Console.WriteLine("Enter right day!");
            //        }
            //    }
            //    else if (year % 4 != 0)
            //    {
            //        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            //        {
            //            if (day >= 1 && day <= 31)
            //            {
            //                if (day < current_day)
            //                {
            //                    d = current_day - day;

            //                    if (month < current_month)
            //                    {
            //                        m = current_month - month;
            //                    }
            //                    else if (month > current_month)
            //                    {
            //                        current_month = current_month + 12;
            //                        m = current_month - month;
            //                        current_year--;
            //                    }
            //                    y = current_year - year;
            //                }
            //                else if (day > current_day)
            //                {
            //                    current_day = current_day + 30;
            //                    d = current_day - day;
            //                    current_month--;

            //                    if (month < current_month)
            //                    {
            //                        m = current_month - month;
            //                    }
            //                    else if (month > current_month)
            //                    {
            //                        current_month = current_month + 12;
            //                        m = current_month - month;
            //                        current_year--;
            //                    }
            //                    y = current_year - year;
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("Enter right day!");
            //            }
            //        }
            //        else if (month == 4 || month == 6 || month == 9 || month == 11)
            //        {
            //            if (day >= 1 && day <= 30)
            //            {
            //                if (day < current_day)
            //                {
            //                    d = current_day - day;

            //                    if (month < current_month)
            //                    {
            //                        m = current_month - month;
            //                    }
            //                    else if (month > current_month)
            //                    {
            //                        month = month + 12;
            //                        m = current_month - month;
            //                        year--;
            //                    }
            //                    y = current_year - year;
            //                }
            //                else
            //                {
            //                    day = day + 30;
            //                    month--;
            //                    if (month < current_month)
            //                    {
            //                        m = current_month - month;
            //                    }
            //                    else if (month > current_month)
            //                    {
            //                        month = month + 12;
            //                        m = current_month - month;
            //                        year--;
            //                    }
            //                    y = current_year - year;
            //                }
            //            }
            //            else
            //                Console.WriteLine("Enter right day!");
            //        }
            //        else if (month == 2)
            //        {
            //            if (day >= 1 && day <= 28)
            //            {
            //                if (day < current_day)
            //                {
            //                    d = current_day - day;

            //                    if (month < current_month)
            //                    {
            //                        m = current_month - month;
            //                    }
            //                    else if (month > current_month)
            //                    {
            //                        month = month + 12;
            //                        m = current_month - month;
            //                        year--;
            //                    }
            //                    y = current_year - year;
            //                }
            //                else
            //                {
            //                    day = day + 28;
            //                    month--;
            //                    if (month < current_month)
            //                    {
            //                        m = current_month - month;
            //                    }
            //                    else if (month > current_month)
            //                    {
            //                        month = month + 12;
            //                        m = current_month - month;
            //                        year--;
            //                    }
            //                    y = current_year - year;
            //                }
            //            }
            //            else
            //                Console.WriteLine("Enter right day!");
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Please, Enter year between 1980 & 2024 only!");
            //}

            //Console.WriteLine($"Your age is {y} years, {m} months and {d} days.");
            #endregion

            #region problem 7
            /////////////////////////////////

            char ans = 'n';
            int num1 = 0;
            int num2 = 0;
            char op = '-';
            int result = 0;

            
            do
            {
                Console.WriteLine("Enter first number: ");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the operator: ");
                op = char.Parse(Console.ReadLine());
                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        Console.WriteLine($"The result is: {result}");
                        break;
                    case '-':
                        result = num1 - num2;
                        Console.WriteLine($"The result is: {result}");
                        break;
                    case '*':
                        result = num1 * num2;
                        Console.WriteLine($"The result is: {result}");
                        break;
                    case '/':
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine($"The result is: {result}");
                        }
                        else
                            Console.WriteLine("You Can not divide by 0!");
                        break;
                    default:
                        Console.WriteLine("Wrong inputs");
                        break;
                }
                Console.WriteLine("Continue? (y/n)");
                ans = char.Parse(Console.ReadLine());
            }
            while (ans == 'y' || ans == 'Y');
            #endregion

            #region resolve problem 6
            //DateTime today = DateTime.Now;

            //int current_year = today.Year;
            //int current_month = today.Month;
            //int current_day = today.Day;

            //int year;
            //int month;
            //int day;

            //int resy = 0, resm = 0, resd = 0;
            //bool test = true;
            ////Enter year
            //do
            //{
            //    Console.WriteLine("Enter a year between 1980 and 2024: ");
            //    year = int.Parse(Console.ReadLine());
            //}
            //while (year < 1980 || year > 2024);

            ////Enter month
            //do
            //{
            //    Console.WriteLine("Enter a month: ");
            //    month = int.Parse(Console.ReadLine());
            //}
            //while (month > 12||month<1 );

            ////Enter day

            //do
            //{
            //    test=true;
            //    Console.WriteLine("Enter a day: ");
            //    day = int.Parse(Console.ReadLine());
            //    switch (month) {
            //        case 1:
            //        case 3:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            if (day < 1 || day > 31)
            //            {
            //                test = false;
            //            }
            //            break;
            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            if (day < 1 || day > 30)
            //            {
            //                test = false;
            //            };
            //            break;
            //        case 2:
            //            if ((day < 1 || day > 29)) { 
            //            test = false;
            //            }
            //            if ((year % 4 !=0) && day > 28)
            //            { 
            //                test = false; 
            //            }

            //            ;
            //            break;
            //    }
            //}
            //while (test == false);

            //if (current_day > day)
            //{
            //    resd = current_day - day;
            //}
            //else if (current_day < day)
            //{
            //    switch (month)
            //    {
            //        case 2:
            //            if (year % 4 == 0)
            //            {
            //                current_day += 29;

            //            }
            //            else
            //            {
            //                current_day += 28;

            //            }
            //            break;
            //        case 4:
            //        case 6:
            //        case 9:
            //        case 11:
            //            current_day += 30;

            //            break;
            //        case 3:
            //        case 1:
            //        case 5:
            //        case 7:
            //        case 8:
            //        case 10:
            //        case 12:
            //            current_day += 31;
            //            break;
            //        default:
            //                Console.WriteLine("error");
            //            break;

            //    }
            //    resd = current_day - day;
            //    current_month--;
            //}

            //if (current_month > month)
            //{
            //    resm = current_month - month;
            //}
            //else if (current_month < month) 
            //{
            //    current_month += 12;
            //    resm = current_month - month;
            //    current_year--;
            //}

            //resy = current_year - year;

            //Console.WriteLine($"Your age is {resy} years, {resm} months and {resd} days.");
            #endregion
        }
    }
}
