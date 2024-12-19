namespace c_daylab
{
    internal class Program
    {



        static void Main(string[] args)
        {
            #region array of any numric data type and get min and max value
            /*  float[] numbers = new float[5];

              for (int i = 0; i < numbers.Length; i++)
              {
                  Console.WriteLine($"enter number {i}");
                  numbers[i] = float.Parse(Console.ReadLine());
              }

              Console.WriteLine($"{MyUtility.printMax(numbers)} \n {MyUtility.printMinimum(numbers)}");*/
            #endregion

            #region array of 10 anytype and sort it ascending or decinding without any built in function
            /* float[] numbers = new float[5];
             //read array
             for (int i = 0; i < numbers.Length; i++)
             {
                 Console.WriteLine($"enter number {i}");
                 numbers[i] = float.Parse(Console.ReadLine());
             }
             //sort the array

             //print the array
             MyUtility.sort(numbers, MyUtility.Way.Ascending);
             MyUtility.printArray(numbers);
             MyUtility.sort(numbers, MyUtility.Way.Descending);
             MyUtility.printArray(numbers);*/
            /* for (int i = 0; i < numbers.Length; i++)
             {
                 Console.Write($"{numbers[i]}\t");

             }*/



            #endregion

            #region array of 10  any type and search number and get index
        /*    float[] numbers = new float[10];
            //read array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"enter number {i}");
                numbers[i] = float.Parse(Console.ReadLine());
            }
            //search array
            Console.WriteLine($"enter number you wanrt to search");
            float number = float.Parse(Console.ReadLine());

            int index = MyUtility.findNumber(numbers, number);
            Console.WriteLine(index);*/

            #endregion

            #region 4-matrix  3*2   *  2*1   =3*1  [BONUS]3*3   * 3*2    = 3*2
            /*   int[,] matrix1 = new int[3, 3];
               int[,] matrix2 = new int[3, 2];
               int[,] mulmatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
               //read matrix 1
               for (int i = 0; i < matrix1.GetLength(0); i++)
               {
                   for (int j = 0; j < matrix1.GetLength(1); j++)
                   {
                       Console.WriteLine($"enter number {i}{j}");
                       matrix1[i, j] = int.Parse(Console.ReadLine());
                   }
               }
               //read matrix 2
               for (int i = 0; i < matrix2.GetLength(0); i++)
               {
                   for (int j = 0; j < matrix2.GetLength(1); j++)
                   {
                       Console.WriteLine($"enter number {i}{j}");
                       matrix2[i, j] = int.Parse(Console.ReadLine());
                   }
               }
               //matrix mult
               for (int i = 0; i < mulmatrix.GetLength(0); i++)
               {
                   for (int j = 0; j < mulmatrix.GetLength(1); j++)
                   {
                       for (int k = 0; k < matrix1.GetLength(1); k++)
                       {
                           mulmatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                       }

                   }
               }
               //print matrix
               for (int i = 0; i < mulmatrix.GetLength(0); i++)
               {
                   for (int j = 0; j < mulmatrix.GetLength(1); j++)
                   {
                       Console.Write($"{mulmatrix[i, j]}\t");

                   }
                   Console.WriteLine();
               }

   */

            #endregion
            #region   array of 3 rows,4 cols read and write   int[,] arr = new int[3, 4];add get average of columns
            /*//read matrix 1
            int[,]matrix1 = new int[3,4];
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    Console.WriteLine($"enter number {i}{j}");
                    matrix1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //caculate avreage
            int[] avreage = new int[matrix1.GetLength(1)];
            for (int i = 0; i < matrix1.GetLength(1); i++)
            {
                for (int j = 0; j < matrix1.GetLength(0); j++)
                {
                    avreage[i] += matrix1[j, i];
                }
                avreage[i] /= matrix1.GetLength(0);
            }
            //print avg
            for (int i = 0; i < avreage.Length; i++)
            {
                Console.Write($"{avreage[i]}\t");

            }*/
            #endregion

            #region 5- calculate your birth date
            /*            int currentDay = DateTime.Now.Day;
                        int currentmonth = DateTime.Now.Month;
                        int currentyear = DateTime.Now.Year;
                        int yourDay, yourMonth, yourYear, yourYearAge, yourMonthAge, yourDayAge;
                        do
                        {
                            Console.WriteLine("enter your birthday month");
                            yourMonth = int.Parse(Console.ReadLine());
                        } while (yourMonth < 0 || yourMonth > 12);

                        do
                        {
                            Console.WriteLine("enter your birthday year");
                            yourYear = int.Parse(Console.ReadLine());
                        } while (yourYear < 1980 || yourYear > 2024);
                        int maxDay = 0;
                        ///1,3,5,7,8,10,12     31days
                        //////4,6,9,11           30 days
                        //////2      28,29 leap year
                        switch (yourMonth)
                        {
                            case 1:
                            case 3:
                            case 5:
                            case 7:
                            case 10:
                            case 12:
                                maxDay = 31;
                                break;
                            case 4:
                            case 6:
                            case 9:
                            case 11:
                                maxDay = 30;
                                break;

                            case 2:
                                {
                                    if (DateTime.IsLeapYear(yourYear))
                                    {
                                        maxDay = 29;
                                    }
                                    else
                                    {
                                        maxDay = 28;
                                    }
                                }
                                break;
                        }
                        do
                        {
                            Console.WriteLine("enter your birthday day");
                            yourDay = int.Parse(Console.ReadLine());
                        } while (yourDay > maxDay || yourDay < 0);
                        yourDayAge = currentDay - yourDay;
                        if (yourDayAge < 0)
                        {
                            yourDayAge = maxDay + yourDayAge;
                            currentmonth -= 1;
                        }
                        yourMonthAge = currentmonth - yourMonth;
                        if (yourMonthAge < 0)
                        {
                            yourMonthAge += 12;
                            currentyear -= 1;
                        }
                        yourYearAge = currentyear - yourYear;
                        Console.WriteLine($"you are {yourYearAge} years and {yourMonthAge} month and {yourDayAge} day");*/
            #endregion
            #region simple calculator
            /*  Char cont = 'n';
              do {
                  int number1, number2, answer = 0;
                  char opreator;
                  Console.WriteLine("enter first number");
                  number1 = int.Parse(Console.ReadLine());
                  Console.WriteLine("enter second number");
                  number2 = int.Parse(Console.ReadLine());
                  Console.WriteLine("enter opreator");
                  opreator = char.Parse(Console.ReadLine());
                  switch (opreator)
                  {
                      case '+':
                          answer = number1 + number2;
                          break;
                      case '-':
                          answer = number1 - number2;
                          break;
                      case '*':
                          answer = number1 * number2;
                          break;
                      case '/':
                          answer = number1 / number2;
                          break;
                      case '%':
                          answer = number1 % number2;
                          break;
                      default:
                          Console.WriteLine("enter valid opreator");
                          break;
                  }
                  Console.WriteLine($"the answer is {answer}");
                  Console.WriteLine("do you want to do another opreation y,n");
                  cont = char.Parse(Console.ReadLine());


              } while (cont == 'y' || cont == 'Y' );*/
            #endregion
        }
    }
}
