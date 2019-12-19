//using System;

//class StringTokenizer {
//    string[] tokens;

//    public StringTokenizer(string str, char delimiter) {
//        tokens = str.Split(delimiter);
//    }

//    public int Length {
//        get { return tokens.Length; }
//    }

//    public string this[int idx] {
//        get { return tokens[idx]; }
//    }
//}

//class _10Enums {
//    public static void Main() {
//        // 문자열에 대하여 특정 구분자를 사용하여 토큰으로 분리하는 클래스를 설계해 봅시다.
//        StringTokenizer tokens = new StringTokenizer("192.168.0.1", '.');
//        //Console.WriteLine(tokens[0]);   // 192
//        //Console.WriteLine(tokens[1]);   // 168
//        //Console.WriteLine(tokens[2]);   // 0
//        //Console.WriteLine(tokens[3]);   // 1
//        int i = 0; 
//        while (i < tokens.Length) {
//            Console.WriteLine(tokens[i]);
//            ++i;
//        }

//    }
//}










//using System;

//// step 1. 이전 코드의 문제는 토큰을 순회하기 위해 인덱스를 사용자가 제어해야 한다는 것입니다.
//// 이를 해결하는 방법은 인덱스가 없이 토큰을 순회해야 한다는 것입니다.
//// 그래서 이를 해결하기 위해 다음 요소가 있으면 데이터를 꺼내오고 다음 요소가 없으면 
//// 데이터를 꺼내오지 말자는 것입니다. 이제 이를 위한 메서드를 추가합니다.
//class StringTokenizer {
//    string[] tokens;
//    int position = -1;  // 다음 요소를 꺼내 오기 위해

//    // 다음 요소가 있는지 확인하는 메서드입니다.
//    public bool MoveNext() {
//        ++position;
//        return position < tokens.Length;
//    }

//    // 현재 요소를 꺼내오는 프로퍼티를 추가합니다.
//    public string Current {
//        get { return tokens[position]; }
//    }

//    // 현재 요소를 다시 순회할 수 있도록 초기화하는 메서드를 제공합니다.
//    public void Reset() { position = -1; }

//    public StringTokenizer(string str, char delimiter) {
//        tokens = str.Split(delimiter);
//    }

//    public int Length {
//        get { return tokens.Length; }
//    }

//    public string this[int idx] {
//        get { return tokens[idx]; }
//    }
//}

//class _10Enums {
//    public static void Main() {
//        StringTokenizer tokens = new StringTokenizer("192.168.0.1", '.');
//        //int i = 0;
//        //while (i < tokens.Length) {
//        //    Console.WriteLine(tokens[i]);
//        //    ++i;
//        //}
//        while (tokens.MoveNext())
//            Console.WriteLine(tokens.Current);

//        tokens.Reset();
//        while (tokens.MoveNext())
//            Console.WriteLine(tokens.Current);

//    }
//}








//using System;

//// step 2. 이전의 코드는 한 가지 단점이 있는데 이는 객체를 순회하기 위한 방법이 표준화되지
//// 않아 사용하기가 어렵다는 것입니다. 이제 객체를 순회하는 방법을 표준화하기 위해 인터페이스를
//// 도입합니다.
//interface IIterator {
//    // 인덱스를 1 증분시켜 해당 객체의 끝에 도달했는지의 여부를 반환합니다.
//    bool MoveNext();

//    // 인덱스를 -1로 설정하는 메서드입니다.
//    void Reset();

//    // 현재 위치의 객체를 반환하는 프로퍼티 입니다.
//    object Current { get; } // 모든 타입을 반환하기 위해 object 타입을 사용합니다.
//}

//// 이제 순회를 하기 위한 클래스는 IIterator 인터페이스를 구현합니다.
//class StringTokenizer : IIterator {
//    string[] tokens;
//    int position = -1; 

//    public bool MoveNext() {
//        ++position;
//        return position < tokens.Length;
//    }

//    public object Current {
//        get { return tokens[position]; }
//    }

//    public void Reset() { position = -1; }

//    public StringTokenizer(string str, char delimiter) {
//        tokens = str.Split(delimiter);
//    }

//    public int Length {
//        get { return tokens.Length; }
//    }

//    public string this[int idx] {
//        get { return tokens[idx]; }
//    }
//}

//// 현재 토크나이저에 대하여 동시에 순회가 되도록 코드를 수정해 보세요 :D
//class _10Enums {
//    public static void Main() {
//        StringTokenizer tokens = new StringTokenizer("192.168.0.1", '.');
//        tokens.Reset();
//        while (tokens.MoveNext())
//            Console.WriteLine(tokens.Current);

//    }
//}











//using System;

//// step 3. 이전의 코드는 순회를 다시 할 수 있지만 동시 순회는 불가능합니다. 이는 순회를 위한 위치 정보를
//// 토큰 객체가 가지고 있기 때문이다. 동시에 순회가 가능하도록 위치 정보를 별도의 객체를 사용하여
//// 관리하도록 코드를 구현합니다.
//interface IIterator {
//     bool MoveNext();
//    void Reset();
//    object Current { get; }
//}

//// 위치를 관리하는 클래스를 설계합니다.
//class Iterator : IIterator {
//    string[] tokens;
//    int position = -1;

//    public Iterator(string[] tokens) {
//        this.tokens = tokens;
//    }

//    public bool MoveNext() {
//        ++position;
//        return position < tokens.Length;
//    }

//    public object Current {
//        get { return tokens[position]; }
//    }

//    public void Reset() { position = -1; }
//}

//// 그리고 아래의 클래스는 Iterator 객체를 반환하는 메서드를 제공하도록 합니다.
//class StringTokenizer {
//    string[] tokens;

//    public IIterator GetIterator() {
//        return new Iterator(tokens);
//    }

//    public StringTokenizer(string str, char delimiter) {
//        tokens = str.Split(delimiter);
//    }

//    public int Length {
//        get { return tokens.Length; }
//    }

//    public string this[int idx] {
//        get { return tokens[idx]; }
//    }
//}

//class _10Enums {
//    public static void Main() {
//        StringTokenizer tokens = new StringTokenizer("192.168.0.1", '.');

//        IIterator i1 = tokens.GetIterator();
//        IIterator i2 = tokens.GetIterator();

//        if (i1.MoveNext()) Console.WriteLine(i1.Current);
//        if (i2.MoveNext()) Console.WriteLine(i2.Current);

//        if (i1.MoveNext()) Console.WriteLine(i1.Current);
//        if (i2.MoveNext()) Console.WriteLine(i2.Current);

//        if (i1.MoveNext()) Console.WriteLine(i1.Current);
//        if (i2.MoveNext()) Console.WriteLine(i2.Current);

//        if (i1.MoveNext()) Console.WriteLine(i1.Current);
//        if (i2.MoveNext()) Console.WriteLine(i2.Current);


//    }
//}














//using System;

//// step 4. 이전 코드는 순회를 위한 객체를 꺼내오는 방법이 표준화되지 않았다는 것입니다. 이를 위해 객체를
//// 꺼내오기 위한 인터페이스를 도입합니다.
//interface IIterator {
//    bool MoveNext();
//    void Reset();
//    object Current { get; }
//}

//// 객체를 꺼내오기 위한 인터페이스
//interface IIterable {
//    IIterator GetIterator();
//}

//class Iterator : IIterator {
//    string[] tokens;
//    int position = -1;

//    public Iterator(string[] tokens) {
//        this.tokens = tokens;
//    }

//    public bool MoveNext() {
//        ++position;
//        return position < tokens.Length;
//    }

//    public object Current {
//        get { return tokens[position]; }
//    }

//    public void Reset() { position = -1; }
//}

//// 이제 객체를 꺼내오기 위한 인터페이스를 구현합니다.
//class StringTokenizer : IIterable {
//    string[] tokens;

//    public IIterator GetIterator() {
//        return new Iterator(tokens);
//    }

//    public StringTokenizer(string str, char delimiter) {
//        tokens = str.Split(delimiter);
//    }

//    public int Length {
//        get { return tokens.Length; }
//    }

//    public string this[int idx] {
//        get { return tokens[idx]; }
//    }
//}

//class _10Enums {
//    public static void Main() {
//        StringTokenizer tokens = new StringTokenizer("192.168.0.1", '.');

//        IIterator i1 = tokens.GetIterator();
//        IIterator i2 = tokens.GetIterator();

//        if (i1.MoveNext()) Console.WriteLine(i1.Current);
//        if (i2.MoveNext()) Console.WriteLine(i2.Current);

//        if (i1.MoveNext()) Console.WriteLine(i1.Current);
//        if (i2.MoveNext()) Console.WriteLine(i2.Current);

//        if (i1.MoveNext()) Console.WriteLine(i1.Current);
//        if (i2.MoveNext()) Console.WriteLine(i2.Current);

//        if (i1.MoveNext()) Console.WriteLine(i1.Current);
//        if (i2.MoveNext()) Console.WriteLine(i2.Current);


//    }
//}













using System;

// step 5. 이전의 코드는 반복을 위한 자료구조(StringTokenizer)와 반복을 위한 객체(Iterator)가
// 이원화되어 있습니다. 이는 캡슐화를 만족하지 않으므로 이제 Iterator 클래스를 StringTokenizer 안으로
// 넣도록 하겠습니다.
interface IIterator
{
    bool MoveNext();
    void Reset();
    object Current { get; }
}

interface IIterable
{
    IIterator GetIterator();
}

class StringTokenizer : IIterable
{
    string[] tokens;

    public IIterator GetIterator()
    {
        return new Iterator(tokens);
    }

    public StringTokenizer(string str, char delimiter)
    {
        tokens = str.Split(delimiter);
    }

    public int Length {
        get { return tokens.Length; }
    }

    public string this[int idx] {
        get { return tokens[idx]; }
    }

    class Iterator : IIterator
    {
        string[] tokens;
        int position = -1;

        public Iterator(string[] tokens)
        {
            this.tokens = tokens;
        }

        public bool MoveNext()
        {
            ++position;
            return position < tokens.Length;
        }

        public object Current {
            get { return tokens[position]; }
        }
        public void Reset() { position = -1; }
    }
}

class _10Enums
{
    public static void Main()
    {
        StringTokenizer tokens = new StringTokenizer("192.168.0.1", '.');
        IIterator i = tokens.GetIterator();
        while (i.MoveNext())
            Console.WriteLine(i.Current);
    }
}

// 이와 같이 자료구조를 순회하는 객체를
// C++, Java: 반복자(iterator)
// C#: 열거자(Enumerator)
// 라고 합니다.

// 연습 문제
// 알파벳 대문자를 생성하고 순차적으로 순회하는 코드를 구현해 보세요.
// 이 때, IIterator, IIterable 인터페이스를 반드시 사용해야 합니다.

public static void Main()
{
    AtoZ atoz = new AtoZ(); // ABCDEFG....XYZ

    IIterator itr = atoz.GetIterator();
    while (itr.MoveNext())
        Console.Write(itr.Current); // ABCDEFGHIJKLMNOPQRSTUVWXYZ
    Console.WriteLine();
}
