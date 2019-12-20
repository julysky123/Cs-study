using System;
using System.Collections.Generic;


delegate int Method(int n, int m); // 'int(int,int)' 형식의 메서드를 저장하기 위한 타입 선언.

delegate bool CompareMethod(int a);      //약간 함수포인터 느낌.


//델리게이트를 선언하지 않고도 사용할수 잇는 일종의 래퍼도 제공.
//1. Action : 반환값이 없는 델리게이트.
//2. Func : 반환 값이 있는 델리게이트.

    //delegate void Action();
    //delegate void Action<T> (T arg);
    //delegate void Acton<T1,T2> (T1 arg1, T2 arg);
    // 최대 16개까지의 매개변수 가질수있다.

//C#은 익명 메서드, 익명 델리게이트보다 더 추상화된 메서드를 제공하는데 이를 람다 표현식이라고 한다.
// 사용방법 : ([변수명,[...]])=> 표현식
// 화살표 => 의 의미 : 수학의 람다 새우세서 사용하는 기호를 차용.

class Delegate
{
    static int Add(int a, int b) { return a + b; }
    static int Sub(int a, int b) { return a - b; }
    static int Mul(int a, int b) { return a * b; }
    static int Div(int a, int b) { return a / b; }
    static int Square(int a) { return a * a; }

    static bool Ascending(int a, int b) { return a > b; }
    static bool Descending(int a, int b) { return a < b; }

    static int Count(int[] arr, CompareMethod cc)
    {
        int cnt = 0;
        foreach( var e in arr)
        {
            if (cc(e)) ++cnt;
        }
        return cnt;
    }
    static bool IsOdd(int a) { return a % 2 == 1; }
    static bool IsEven(int a) { return a % 2 == 0; }
    public static void Main()
    {
        Method method = new Method(Add);    //메서드를 타입으로 저장.
        Console.WriteLine(method.Invoke(1, 1));
        Console.WriteLine(method(1, 1));

        Method method1 = Sub;   //메서드를 바로 대입하는 것도 가능.
        Console.WriteLine(method1(1, 1));
        method1 = Add;  //교체도 가능.

        Method[] calcul = { Add, Sub, Mul, Div };
        int result = 0;
        result = calcul[0](6, 3); Console.WriteLine(result);
        result = calcul[1](6, 3); Console.WriteLine(result);
        result = calcul[2](6, 3); Console.WriteLine(result);
        result = calcul[3](6, 3); Console.WriteLine(result);



        int[] abc = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 13 };
        Console.WriteLine("짝수의 갯수: " + Count(abc, IsEven));
        Console.WriteLine("홀수의 갯수: " + Count(abc, IsOdd));
        //단 한번만 사용할 메서드에 대해서 delegate를 하는법.
        //delegate(int a,int b) {return a>b;} 를 해당하는 위치에 집어넣는다.
        //익명 메서드. 익명 델리게이트.
        Console.WriteLine("짝수의 갯수: " + Count(abc, delegate (int n) { return n % 2 == 0; }));
        Console.WriteLine("홀수의 갯수: " + Count(abc, delegate (int n) { return n % 2 == 1; }));
        //단 메서드의 시그니처가 다르면 저장불가.

        //람다 표현식. (매개변수가 1개인경우 괄호 생략가능.)
        //매개변수가 없으면 괄호생략 불가.
        Console.WriteLine("짝수의 갯수: " + Count(abc, a=>a%2==0));
        Console.WriteLine("홀수의 갯수: " + Count(abc, a=>a%2==1));


    }
}

