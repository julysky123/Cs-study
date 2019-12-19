using System;
using System.Collections;           //넌 제네릭 컬렉션(C# 1.0)
using System.Collections.Generic;   //제네릭 컬렉션(C# 2.0)
//컬렉션 프레임워크 : C# 언어가 제공하는 자료구조 라이브러리
//System.Collections: C# 1.0에서 제공하는 컬렉션 라이브러리로 넌 제네릭으로 구현되어있다.
//System.Collections.Generics: C# 2.0에서 제공하는 컬렉션 라이브러리로 제네릭으로 구현되어있다.

class Collections
{
    //1. 선형 자료구조 : 구현에 관계없이 데이터가 순차적으로 지정되고 중복된 값을 허용하는 자료구조.

    static void PrintArray(Array a)
    {
        
        foreach (var e in a)
        {
            Console.Write($"{e,2}");
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    class Person :IComparable
    {
        string name;
        int age;

        public string GetName() { return name; }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public int CompareTo(object obj)
        {
            int age = ((Person)obj).age;
            if (this.age == age) return 0;
            return (this.age > age) ? 1 : -1;
        }

        public override string ToString()
        {
            return $"{name}({age})";
        }

        public static IComparer GetAscendingName()
        {
            return new AscendingName();
        }
        public static IComparer GetDescendingName()
        {
            return new DescendingName();
        }

        class AscendingName : IComparer
        {
            public int Compare(object x, object y)
            {
                string name1 = ((Person)x).GetName();
                string name2 = ((Person)y).GetName();
                return name1.CompareTo(name2);
            }
        }
        class DescendingName : IComparer
        {
            public int Compare(object x, object y)
            {
                string name1 = ((Person)x).GetName();
                string name2 = ((Person)y).GetName();
                return name2.CompareTo(name1);
            }
            
        }
    }

    class Complex : IComparable
    {
        int real, imag;
        public Complex(int real, int imag)
        {
            this.real = real;
            this.imag = imag;
        }

        public override string ToString()
        {
            return $"{real}+{imag}i ";
        }
        public int CompareTo(object obj)
        {
            int real = ((Complex)obj).real;
            if (this.real == real) return 0;
            return (this.real > real)?1:-1;
        }
        public static IComparer GetAscendingImag()
        {
            return new AscendingImag();
        }
        public static IComparer GetDescendingImag()
        {
            return new DescendingImag();
        }

        class AscendingImag : IComparer
        {
            public int Compare(object x, object y)
            {
                int imag1 = ((Complex)x).imag;
                int imag2 = ((Complex)y).imag;
                return imag2.CompareTo(imag1);
            }
        }
        class DescendingImag : IComparer
        {
            public int Compare(object x, object y)
            {
                int imag1 = ((Complex)x).imag;
                int imag2 = ((Complex)y).imag;
                return imag1.CompareTo(imag2);
            }
        }
    }


    public static void Main()
    {
        List<int> arr = new List<int>();
        arr.Add(3);
        arr.Add(4);
       // PrintArray(arr);

        Person[] people = { new Person("susan", 20), new Person("daniel", 10), new Person("alice", 30) };
        Array.Sort(people);
        PrintArray(people); //기본정렬.
        Array.Sort(people, Person.GetAscendingName());
        PrintArray(people);
        Array.Sort(people, Person.GetDescendingName());
        PrintArray(people);
        Complex[] cp = { new Complex(1, 5), new Complex(2, 4), new Complex(3, 2), new Complex(4, 3), new Complex(5, 1) };
        Array.Sort(cp);
        PrintArray(cp);
        Array.Sort(cp,Complex.GetAscendingImag());
        PrintArray(cp);
        Array.Sort(cp, Complex.GetDescendingImag());
        PrintArray(cp);
    }
    
}

