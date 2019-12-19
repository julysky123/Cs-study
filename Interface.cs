//추상 클래스 : 기능과 강제 구현 사항을 제공하는 클래스
//인터페이스 : 기능으 뺀 강제 구현 사항만 제공하는 클래스
//즉 인터페이스는 추상 메서드만 가지고 있는 클래스.


//interface 인터페이스명 {
//  어떠한 클래스가 반드시 구현해야 할 메서드를 기술.    
//}
//접두어를 I로 사용.

using System;

interface ICommonBehavior
{
    //인터페이스 안에 선언된 메서드는 외부에서 호출하여 사용해야 하므로 접근지정자는 항상 public. -> 그냥 인터페이스에 존재하는 메서드는 public을 사용하지 않아도 된다. 그리고 사용하면 안됨.
    //abstract도.
    void Move();
    void Stop();
}

class Marine : ICommonBehavior
{
    public void Move() { Console.WriteLine("move"); }   //오버라이드를 쓰지않는다.
    public void Stop() { Console.WriteLine("stop"); }
}


class Interface
{
    public static void Main()
    {
        
    }
}

