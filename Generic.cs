using System;

//generic. 타입에 따른 클래스 생성하는개념.
class Stack<t>
{
    t[] arr = null;
    int top = 0;

    public Stack(int size) { arr = new t[size]; }

    public bool Empty() { return top == 0;}
    public bool Full() { return top == arr.Length; }
    public void Push(t data) { arr[top++] = data;}
    public t Pop() { return arr[--top]; }
}

class Generic
{
    public static void Main1()
    {
        //Stack은 제네릭(틀)이다. Open Type.
        Stack<int> s = new Stack<int>(100);
        Stack<double> d = new Stack<double>(100);   //Stack<int>는 타입. Close Type.
        s.Push(10);
        d.Push(1.123);
        int data = s.Pop();
        double dd = d.Pop();
        Console.WriteLine($"{data},{dd}");
    }
}


