using System;
using System.Collections.Generic;

// 어제 마지막 시간에 사용했던 복소수 클래스를 복사해 오세요 :D
class Complex : IComparable
{
    public int Real { get; }
    public int Imag { get; }

    public Complex(int real, int imag)
    {
        Real = real;
        Imag = imag;
    }

    public int CompareTo(object obj)
    {
        int real = ((Complex)obj).Real;
        return Real.CompareTo(real);
    }

    public override string ToString() { return $"({Real}+{Imag}j)"; }

    class AscendingImaginary : IComparer<Complex>
    {
        //public int Compare(object x, object y) {
        //    int imag1 = ((Complex)x).Imag;
        //    int imag2 = ((Complex)y).Imag;
        //    return imag1.CompareTo(imag2);
        //}

        public int Compare(Complex x, Complex y)
        {
            int imag1 = x.Imag;
            int imag2 = y.Imag;
            return imag1.CompareTo(imag2);
        }
    }

    class DescendingImaginary : IComparer<Complex>
    {
        //public int Compare(object x, object y) {
        //    int imag1 = ((Complex)x).Imag;
        //    int imag2 = ((Complex)y).Imag;
        //    return imag2.CompareTo(imag1);
        //}

        public int Compare(Complex x, Complex y)
        {
            int imag1 = x.Imag;
            int imag2 = y.Imag;
            return imag2.CompareTo(imag1);
        }
    }

    public static IComparer<Complex> GetAscendingImaginary()
    {
        return new AscendingImaginary();
    }

    public static IComparer<Complex> GetDescendinImaginary()
    {
        return new DescendingImaginary();
    }
}

class Program
{
    static void PrintArray(List<Complex> arr)
    {
        foreach (var e in arr)
            Console.Write(e + " ");
        Console.WriteLine();
    }
    static void Main(string[] args)
    {
        //ArrayList arr = new ArrayList() {
        //    new Complex(2, 4), new Complex(3, 2), new Complex(1, 3)
        //};

        //arr.Sort(); PrintArray(arr);
        //arr.Reverse(); PrintArray(arr);
        //Console.WriteLine();

        //arr.Sort(Complex.GetAscendingImaginary()); PrintArray(arr);
        //arr.Sort(Complex.GetDescendinImaginary()); PrintArray(arr);
        // ------------------------------------------------------------

        List<Complex> arr = new List<Complex>() {
            new Complex(2, 4), new Complex(3, 2), new Complex(1, 3)
        };

        arr.Sort(); PrintArray(arr);
        arr.Reverse(); PrintArray(arr);
        Console.WriteLine();

        arr.Sort(Complex.GetAscendingImaginary()); PrintArray(arr);
        arr.Sort(Complex.GetDescendinImaginary()); PrintArray(arr);

    }
}

// Array(int[], double[], ...), ArrayList, List<T> -> 배열을 사용하여 구현되어 있습니다.
// LinkedList -> 노드를 사용하여 구현되었습니다.

