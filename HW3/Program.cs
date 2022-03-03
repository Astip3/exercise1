// See https://aka.ms/new-console-template for more information

using System;
using System.Security.Cryptography;
using HW3;


class Program
{
    public static void Main()
    {

        Console.Write("Общие проверки:");
        Console.WriteLine();

        Console.WriteLine(RomanNumber.Add(new RomanNumber(20), new RomanNumber(10)));
        Console.WriteLine(RomanNumber.Sub(new RomanNumber(20), new RomanNumber(10)));
        Console.WriteLine(RomanNumber.Mul(new RomanNumber(20), new RomanNumber(10)));
        Console.WriteLine(RomanNumber.Div(new RomanNumber(20), new RomanNumber(10)));
        Console.WriteLine();

        Console.Write("Общие проверки операторов:");
        Console.WriteLine();

        RomanNumber[] romanNumberArrayOpSum = new RomanNumber[10];
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine();
            Console.WriteLine("i-ый элемент: " + i + " SUM:");
            romanNumberArrayOpSum[i] = new RomanNumber((ushort)(i + 1));
            Console.WriteLine("Элемент массива: " + romanNumberArrayOpSum[i]);
            romanNumberArrayOpSum[i] = (romanNumberArrayOpSum[i] + new RomanNumber((ushort)(i + 1)));

            Console.WriteLine("Элемент массива после: " + romanNumberArrayOpSum[i]);
            Console.WriteLine();
        }
        Console.WriteLine();

        RomanNumber[] romanNumberArrayOpSub = new RomanNumber[10];
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine();
            Console.WriteLine("i-ый элемент: " + i + " SUB:");
            romanNumberArrayOpSub[i] = new RomanNumber((ushort)((i+1) * 2));
            Console.WriteLine("Элемент массива: " + romanNumberArrayOpSub[i]);
            romanNumberArrayOpSub[i] = (romanNumberArrayOpSub[i] - new RomanNumber((ushort)(i + 1)));

            Console.WriteLine("Элемент массива после: " + romanNumberArrayOpSub[i]);
            Console.WriteLine();
        }
        Console.WriteLine();

        RomanNumber[] romanNumberArrayOpMul = new RomanNumber[10];
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine();
            Console.WriteLine("i-ый элемент: " + i + " MUL:");
            romanNumberArrayOpMul[i] = new RomanNumber((ushort)((i+1) * 2));
            Console.WriteLine("Элемент массива: " + romanNumberArrayOpMul[i]);
            romanNumberArrayOpMul[i] = (romanNumberArrayOpMul[i] * new RomanNumber((ushort)(i + 1)));

            Console.WriteLine("Элемент массива после: " + romanNumberArrayOpMul[i]);
            Console.WriteLine();
        }
        Console.WriteLine();

        RomanNumber[] romanNumberArrayOpDiv = new RomanNumber[10];
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine();
            Console.WriteLine("i-ый элемент: " + i + " DIV:");
            romanNumberArrayOpDiv[i] = new RomanNumber((ushort)((i+1) * 2));
            Console.WriteLine("Элемент массива: " + romanNumberArrayOpDiv[i]);
            romanNumberArrayOpDiv[i] = (romanNumberArrayOpDiv[i] / new RomanNumber((ushort)(i + 1)));

            Console.WriteLine("Элемент массива после: " + romanNumberArrayOpDiv[i]);
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}