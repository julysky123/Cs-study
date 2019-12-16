using System;

class Cursor
{
    //유일한 객체를 생성하는 방법 1. 사용자가 객체를 임의로 생성하지 못하도록
    //기본 생성자를 private 속성으로 지정한다.
    Cursor() { }

    //유일한 객체를 생성하는 방법 2. 유일한 객체를 반환하는 정적 메서드를 제공합니다.
    static Cursor sInstance = new Cursor();
    public static Cursor GetInstance()
    {
        return sInstance;       //미리 만들어진거 넘김.
    }
}

class Class4
{
    public static void Main()
    {
        //Cursor c1 = new Cursor();
        //Cursor c2 = new Cursor();
        //유일한 객체를 생성하는 디자인 패턴을 singleton pattern 이라고 한다.
        // 여러 상황들을 해결할 디자인패턴들을 학습하자.
        Cursor c1 = Cursor.GetInstance();
        Cursor c2 = Cursor.GetInstance();
        //C#에서는 객체의 식별을 위해 4바이트 정수를 사용한다. 이 값을 출력하려면
        //아래의 매서드를 호출하자.
        Console.WriteLine(c1.GetHashCode());
        Console.WriteLine(c2.GetHashCode());
        //다른개체이다.
    }
}

