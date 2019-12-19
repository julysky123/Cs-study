using System;

class Rect
{
    int color = 0;
    public void Draw() { Console.WriteLine("사각형 출력"); }
    public virtual void Color()
    {
        Console.WriteLine("네모색");
    }
}

class RoundRect : Rect
{
    //부모로부터 기능 물려받는다 하더라도 둥근 사각형을 그리는것은 이 클래스의 할일.
    //둥근 사각형을 출력. 그런데 자식이 함수를 재정의했음을 명확히 알려야함. -> new 
    //Method Hiding.
    //public new void Draw() { Console.WriteLine("둥근 사각형 출력"); }

    // 그런데 이전의 코드는 둥근 사각형이 모든 출력을 처리한다.
    // 부모의 기능을 좀더 활용하자.
    public new void Draw()
    {
        Console.Write("둥근 ");
        base.Draw();    //부모의 메서드를 base로 호출한다.
    }
    public override void Color()
    {
        Console.WriteLine("둥근색");

    }

}




class Override2
{
    public static void Main()
    {
        RoundRect rr = new RoundRect();
        rr.Draw();
        rr.Color();
        Rect n = new RoundRect();
        n.Color();
        n.Draw();
        //c#에서 메서드에 대한 기본 바인딩 정책은 정적 바인딩이다.
        //정적 바인딩 : 컴파일 타임에 바인딩이 결정되고
        // 프로그램의 구동 중에 다른 메서드로 변경되지 않는개념

        // 동적 바인딩 : 프로그램 구동중에 메서드가 변경되는 개념.

    }
}

