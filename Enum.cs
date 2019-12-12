using System;

//열거형. 사용자가 구현하는 값의 집합을 정의할 때 사용.

enum Color {  RED, GREEN, BLUE} //열거 안의 요소를 멤버라고 한다.
enum Log { ERR, WARN, INFO}
// 넘버링을 자동으로 해줘서 좋다.

// 아무런 값을 설정하지 않으면 0부터 시작해서 1씩 증가되는 값을 갖고,
// 설정하면, 설정한 값부터 1씩 증가되는 값을 갖는다.
class Enum
{
    static void PaintColor(Color color)
    {
        switch (color)
        {
            case Color.RED: Console.WriteLine("RED"); break;
            case Color.BLUE: Console.WriteLine("BLUE"); break;
            case Color.GREEN: Console.WriteLine("GREEN"); break;

        }
    }

    public static void Main()
    {
        PaintColor(Color.RED);
  //    PaintColor(Log.WORN);// 비록 같은 값을 갖고있어도 타입이 다르다고 판단.
    }
}

