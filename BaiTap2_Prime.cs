// using System;

// namespace Học_C_
// {
//     class Program
//     {
//         public static bool IsPrime(int number) {
//             if (number < 2) return false;
//             if (number == 2) return true;
//             int count = 0;
//             if (number > 2) {
//                 for (int i = 2; i < Math.Sqrt(number); i++) {
//                     if (number % i == 0) count++;
//                 }
//                 if (count == 0) return true;
//                 else return false;
//             }
//             else return false;
//         }
//         public static bool IsPerfectSquare(int number) {
//             double a = Math.Sqrt(number);
//             if (a*a == number) return true;
//             else return false;
//         }
//         static void Main(string[] args)
//         {
//             int number = int.Parse(Console.ReadLine());
//             bool isPrime = IsPrime(number);
//             bool isPerfectSquare = IsPerfectSquare(number);
//             Console.WriteLine("number isprime? " + isPrime);
//             Console.WriteLine("number is perfect square? " + isPerfectSquare);
//         }
//     }
// }
