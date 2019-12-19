using System;
using System.Collections;



//위와 같은 인터페이스는 System.Collections. 네임스페이스 안에 존재.
//IEnumerable == IIterable : 반복 가능한 객체를 반환하는 인터페이스
//IIterator == IEnumerator : 자료구조에 대하여 순회 기능을 제공하는 인터페이스.

class StringTokenizer : IEnumerable
{
    string[] tokens;

    public IEnumerator GetEnumerator()
    {
        return new Enumerator(tokens);
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

    class Enumerator : IEnumerator
    {
        string[] tokens;
        int position = -1;

        public Enumerator(string[] tokens)
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

class Enum
{
    public static void Main1()
    {
        StringTokenizer tokenizer = new StringTokenizer("192.168.0.1", '.');

        IEnumerator e = tokenizer.GetEnumerator();
        while (e.MoveNext()) Console.Write(e.Current + " ");
        Console.WriteLine();


        //foreach를 컴파일러가 위의 식으로 바꿔준다
        foreach (var token in tokenizer) Console.Write(token + " ");
        Console.WriteLine();
    }
}

