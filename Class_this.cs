using System;


class Int321
{
    int val = 9349511; //쓰레기 값이 존재한다고 가정.

    // 자신을 연쇄적으로 호출할때 사용.
    // 자기자신의 요소에 접근.
    public Int321 SetValue(int val)
    {
        this.val = val;
        return this;
    }
    public int GetValue()
    {
        return val;
    }
    public void Display()
    {
        Console.WriteLine($"{this.GetValue()}");
    }
}


class Class2
{
    public static void Main()
    {
        Int321 i = new Int321();
        i.SetValue(0).Display();
        
    }

}
