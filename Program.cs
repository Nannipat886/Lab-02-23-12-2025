using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_02_23_12_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcalater
            string inputA =Console.ReadLine();
            string inputB =Console.ReadLine();
            int a= int.Parse(inputA);
            int b= int.Parse(inputB);
            print_Plus_Result(a,b);
        }
        /// <summary>
        /// Void ชนิดข้อมูลที่ไม่มีการส่งค่ากลับ
        /// </summary>
        static void print_Plus_Result(int sum1,int sum2) 
        {
            int sumMax= sum1 + sum2;
            int Minus = sum1 - sum2;
            int Multi= sum1 * sum2;
            int Divi= sum1 / sum2;
            Console.WriteLine("Your result is (Sum): "+sumMax);
            Console.WriteLine("Your result is (Minus): "+ Minus);
            Console.WriteLine("Your result is (Multi): "+ Multi);
            Console.WriteLine("Your result is (Divi): "+ Divi);
        }
    }
}
