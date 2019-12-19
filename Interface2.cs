using System;

//인터페이스 확장.
//결국 인터페이스는 추상 메서드만 포함되어 있는 클래스.
//따라서 인터페이스도 다른 인터페이스를 상속 할 수 있다.

interface IUndoable { void Undo(); }
interface IReduable :IUndoable { void Redo(); }

class TextEditor : IReduable
{
    public void Undo() { }
    public void Redo() { }
}

//명시적 선언 : 인터페이스의 경우 다중상속이 가능하다. 따라서 서로 다른 인터페이스에 대해 멤버의 심볼들이
//충돌할 수 있다. 이를 해결하기 위해 명시적 선언을 제공한다.
interface I1 { void Foo(); }
interface I2 { int Foo(); }
class Klass : I1, I2
{
    public void Foo() { Console.Write("hello"); }                //이 메서드를 가장 많이 사용한다고 가정.

    //아래와 같이 메서드의 앞에 인터페이스 명을 사용하는 것을 명시적 선언이라고 한다.
    //명시적 선언을 할 경우, 해당 메서드는 public으로 지정할 수 없다.
    int I2.Foo() { Console.Write("hi"); return 0; }       
}

class Interface3
{
    public static void Main1()
    {
        Klass k = new Klass();
        k.Foo();
        ((I2)k).Foo();  //캐스팅을 해서 써야한다.
    }
}

//객체 지향프로그래밍에서 유지보수를 쉽게 하려면 인터페이스 기반으로 설계하는 것이 좋다.
//인터페이스의 장점
//1. 서로다른 객체들을 연결할 수 있다.
//2. 개발 속도가 향상된다.
//3. 유지 보수하기도 좋다.

