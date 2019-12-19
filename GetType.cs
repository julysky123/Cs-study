using System;


class Animal { virtual public void Cry() { Console.WriteLine("멍냐옹"); } }    // 아직 진도 안나갔는데 virtual 추가해봄.

class Dog : Animal { public override void Cry() { Console.WriteLine("멍멍!"); } }
class Cat : Animal { public override void Cry() { Console.WriteLine("냐옹~"); } }

//Reflection. 런타임에 객체의 클래스 타입 메서드 필드등과 같은 정보를 알아내는 기술.

class Apple { }

class Reflection
{
    public static void Main1()
    {
        Apple a = new Apple();
        Type t1 = a.GetType();  //타입을 알려줌,.
        Console.WriteLine(t1.Name);      //Apple      //현재 객체를 만든 클래스의 이름.

        Type t2 = typeof(Apple);
        Console.WriteLine(t2.Name);     //Apple

        //1. 객체 : GetType 메서드 사용
        //2. 타입 : typeof 연산자를 사용


        if (t2 is Apple) //is 연산자 제공.
        {
            Console.WriteLine("t2 is Apple");
        }
        else Console.WriteLine("t2 is not Apple");

        //as연산자 : 안전한 다운캐스팅을 하기 위한 연산자로 캐스팅에 성공하면 그대로 변환
        Apple b = a as Apple; // a를 Apple로 한다. 만약 실패하면 null
        if (b == null) ;
        else;
    }
}

