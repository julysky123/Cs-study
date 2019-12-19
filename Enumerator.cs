using System;

interface IIterator
{
    //인덱스를 1증가.
    bool MoveNext();

    //인덱스를 -1로 설정
    void Reset();

    //현재 위치의 객체를 반환하는 프로퍼티.
    object Current { get; } //모든 타입을 반환하기 위함.

}

interface IIterable
{
    IIterator GetIterator();
}

//c++에서의 반복자 (iterator)을 c#에서는 열거자(enumerator)라고 한다.

class Iterator : IIterator
{
    string[] tokens;
    int position = -1;

  
    public Iterator(string[] tokens)
    {
        this.tokens = tokens;
    }
    public object Current {
        get {
            return tokens[position];
        }
    }
    public bool MoveNext()
    {
        position++;
        return position < tokens.Length;

    }
    public void Reset()
    {
        position = -1;
    }
}

class PosManager
{
   public int position = -1;
}



class StringTokenizer : IIterable
{
    string[] tokens;

    public CharEnumerator iter;
    public IIterator GetIterator()
    {
        return new Iterator(tokens);
    }
    public StringTokenizer(string str, char delimiter)
    {
        tokens = str.Split(delimiter);          //이미 C#에 메서드로 제공됨.
    }
    public string this[int index] {
        get {
            return tokens[index];
        }
    }
    public int Length {
        get { return tokens.Length; }
    }
}




class Enum
{
    public static void Main()
    {
        //문자열에 대하여 특정 구분자를 사용하여 토큰으로 분리하는 클래스를 설계해 봅시다.
        StringTokenizer tokens = new StringTokenizer("192.168.0.1", '.');

        IIterator i1 = tokens.GetIterator();
        IIterator i2 = tokens.GetIterator();
        if (i1.MoveNext()) Console.WriteLine(i1.Current);
        if (i2.MoveNext()) Console.WriteLine(i1.Current);
        if (i1.MoveNext()) Console.WriteLine(i1.Current);
        if (i2.MoveNext()) Console.WriteLine(i1.Current);
        if (i1.MoveNext()) Console.WriteLine(i1.Current);
        if (i2.MoveNext()) Console.WriteLine(i1.Current);
        if (i1.MoveNext()) Console.WriteLine(i1.Current);
        if (i2.MoveNext()) Console.WriteLine(i1.Current);
    }


}

