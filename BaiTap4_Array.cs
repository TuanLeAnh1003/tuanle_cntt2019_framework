// using System;

// namespace Học_C_
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Nhap so phan tu: ");
//             int n = int.Parse(Console.ReadLine());
//             int[] a = new int[n];
//             for (int i = 0; i < n; i++) {
//                 Console.WriteLine("Nhap so thu " + i + ": ");
//                 a[i] = int.Parse(Console.ReadLine());
//             }
//             // Tính max
//             int maxValue = a[0];
//             for (int i = 0; i < n; i++) {
//                 if (a[i] > maxValue) {
//                     maxValue = a[i];
//                 }
//             }
//             // Tính min
//             int minValue = a[0];
//             for (int i = 0; i < n; i++) {
//                 if (a[i] < minValue) {
//                     minValue = a[i];
//                 }
//             }
//             // Tính trung bình
//             float avgValue = 0, sum = 0;
//             for (int i = 0; i < n; i++) {
//                 sum += a[i];
//             }
//             avgValue = sum / n;

//             // Sắp xếp hàm
//             int temp = 0;
//             for (int i = 0; i < n; i++) {
//                 for (int j = i; j < n; j++) {
//                     if (a[j] < a[i]) {
//                         temp = a[i];
//                         a[i] = a[j];
//                         a[j] = temp;
//                     }
//                 }
//             }
//             //Tính median value
//             int medValue = 0;
//             if (a.Length % 2 == 0) {
//                 medValue = (a[n/2 - 1] + a[n/2]) / 2;
//             }
//             else medValue = (a[n/2]);

//             // Xuất giá trị
//             Console.WriteLine("max: " +  maxValue);
//             Console.WriteLine("min: " +  minValue);
//             Console.WriteLine("avg: " +  avgValue);
//             Console.WriteLine("med: " +  medValue);
//         }
//     }
// }
