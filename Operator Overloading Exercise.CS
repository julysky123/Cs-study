using System;

class MyString
{
    // 내부적으로 string 클래스를 사용할 수 없습니다.
    // 문자열을 저장하려면 문자 배열을 사용해야 합니다.
    char[] arr;
    public MyString(string k)
    {
        arr = new char[k.Length];
        //for (int i = 0; i < k.Length; i++) arr[i] = k[i];
        arr = k.ToCharArray();      //이런게 내장 되어있다.
    }
    public override string ToString()
    {
        //string k = null;
        //for (int i = 0; i < arr.Length; i++) k = k + arr[i];
        return new string(arr); //문자열을 집어넣으면 string으로 바꿔줌. 오버로딩이 잘 되어있다.

    }
    public int Length {
        get { return arr.Length; }
    }
    public char this[int val] {
        get { return arr[val];}
        set { arr[val] = value;}
    }
    public static bool operator ==(MyString a, MyString b)
    {
        return a.ToString() == b.ToString();
    }
    public static bool operator !=(MyString a, MyString b)
    {
        return a.ToString() != b.ToString();
    }
    public static MyString operator +(MyString a, MyString b)
    {
        return new MyString(a.ToString() + b.ToString());
    }
    public static explicit operator string(MyString a)
    {
        return new string(a.arr);
    }
    public char[] ToArray()
    {
        char[] tmp = new char[arr.Length];
        for (int i = 0; i < arr.Length; i++) tmp[i] = arr[i];
        return tmp;
    }
}

class _09Exmaple
{
    public static void Main() {
        // 1문제: 표준 출력이 되도록 코드를 구현해 보세요 :D
        Console.WriteLine("1번문제");
         MyString s = new MyString("hello");     // string s = "hello";
         Console.WriteLine(s);                   // hello

        //2문제: 표준 타입을 사용하여 MyString 객체를 생성하는 코드를 구현해 보세요 :D
        Console.WriteLine("2번문제");
        string ss1 = "hello";
         MyString ss2 = new MyString(ss1);
         Console.WriteLine(ss2);                      // hello

        //3번 문제: 문자열의 길이를 반환하는 코드를 구현해 보세요 :D
        Console.WriteLine("3번문제");
        //MyString s = new MyString("hello");             // string s = "hello";
        Console.WriteLine(s.Length);                    // 5

        // 4-1번 문제: 첨자 연산자를 지원하도록 코드를 구현해 보세요 
        Console.WriteLine("4-1번문제");
        // MyString s = new MyString("hello");                 // string s = "hello";
        for (int i = 0; i < s.Length; i++)
             Console.Write(s[i] + " ");
         Console.WriteLine();

        // 4-2번 문제
        Console.WriteLine("4-2번문제");
        // MyString s = new MyString("hello");
        s[0] = '*';
        Console.WriteLine(s);    // *ello

        // 5번 문제
        Console.WriteLine("5번문제");
        MyString s1 = new MyString("hello");
        MyString s2 = new MyString("hello");
        if (s1 == s2) Console.WriteLine("same");
        else          Console.WriteLine("not same");

        if (s1 != s2) Console.WriteLine("not same");
        else          Console.WriteLine("same");

        // 6번 문제
        Console.WriteLine("6번문제");
        MyString s61 = new MyString("hello");
        MyString s62 = new MyString("world");
        MyString s63 = s61 + s62;
        Console.WriteLine(s63);  // helloworld

        // 7번 문제
        Console.WriteLine("7번문제");
        //MyString s1 = new MyString("hello");
        string s32 = (string)s1;
        Console.WriteLine(s32);  // helloS

        // 8번 문제
        Console.WriteLine("8번문제");
        //MyString s1 = new MyString("hello");
        char[] arr = s1.ToArray();
        foreach (var item in arr) {
            Console.Write(item + " ");
        }
        Console.WriteLine();

    }
}

