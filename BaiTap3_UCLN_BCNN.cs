// using System;

// namespace Học_C_
// {
//     class Program
//     {
//         public static int UCLN(int number1, int number2) {
//             int result = 0;
//             for (int i = 1; i < number1 && i < number2; i++) {
//                 if (number1 % i == 0 && number2 % i == 0) result = i;
//             }
//             return result;
//         }
//         public static int BCNN(int number1, int number2) {
//             int result = 0, temp = number1 * number2;
//             for (int i = temp; i > 2; i--) {
//                 if (i % number1 == 0 && i % number2 == 0) result = i;
//             }
//             return result;
//         }
//         static void Main(string[] args)
//         {
//             int number1 = int.Parse(Console.ReadLine());
//             int number2 = int.Parse(Console.ReadLine());
//             int isUCLN = UCLN(number1, number2);
//             int isBCNN = BCNN(number1, number2);
//             Console.WriteLine("UCLN la: " + isUCLN);
//             Console.WriteLine("BCNN la: " + isBCNN);
//         }
//     }
// }
