using System;

class Int32
{
    public int val;
    static int sta_val;
    public void SetValue(int value)
    // 이런 매서드는 객체의 정보와 함계 호출되어야 한다.
    // 이러한 메서드를 인스턴스 메서드라고 한다.
    {
        this.val = value;
    }

    public static void StaticFunc() //클래스 이름으로 호출.
    {
        Console.WriteLine("StaticFunc()");
        //val = 1; static이 아닌 멤버에 접근불가. 정적심볼만 접근가능.
        sta_val = 3;
        //this도 쓸수없음. 당연한얘기.
    }



    static Int32()      //클래스의 정적 데이터를 초기화하기위해 사용되는 생성자
                        //정적 생성자. 최초로 한번만 호출. (일단 사용할때)
    {
        Console.WriteLine("static INT32()");
        sta_val = 0;
    }
    public Int32()
    {
        Console.WriteLine("INT32()");
        val = 1;
    }
}



class Class3
{
    public static void Main()
    {
        Int32 i = new Int32();
        Int32 j = new Int32();
        // 아래와 같이 객체와 함계 호출되는 메서드를 인스턴스 메서드라고 한다.
        i.SetValue(10);

        //Int32.SetValue(10); error.
        Int32.StaticFunc();
    }
}
  

