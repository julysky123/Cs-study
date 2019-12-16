using System;
using static System.Console;
사용자의 이름과 나이를 저장하는 클래스를 설계한다.
class Person
{
    string name;
    int age;

    //public string GetName() { return name;}
    //public void SetName(string value) { name = value; }

    //게터와 세터를 좀 더 편리하게 사용 및 생성할 수 있도록 제공하는 기능 : 프로퍼티.
    public string Name {
        get { return name; }    // Name이 rvalue로 사용되면 get.
        set { name = value; }   // Name이 lvalue로 사용되면 rvalue에 적힌 값을 value로 전달한다.
    }
    public int GetAge() { return age; }
    public void SetAge(int value) { age = value; }
}


class Property
{
    public static void Main()
    {
        Person p = new Person();
        //p.SetName("daniel");
        p.Name = "daniel";
        WriteLine(p.Name);
        p.SetAge(20);
        WriteLine(p.GetAge());

        int[] arr = new int[3];
        WriteLine(arr.Length);  // arr.Length();

    }

}

