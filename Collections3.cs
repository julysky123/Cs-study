using System;
using System.Collections.Generic;


//비선형 자료구조
// Hashtable : C# 1.0에서 제공되는 자료구조로 넌제네릭으로 되어있다.
// Dictionary<KEY, VALUE> : C# 2.0에서 제공되는 자료구조로 제네릭으로 되어있다.

// 두 자료구조 모두 검색을 위한 자료구조이기 때문에 제약 조건이 존재한다.
// 1. 키가 중복될수 없고, 중복된 키를 사용하면 ArgumentException.
// 2. 존재하지 않는 키를 사용할경우, KeyNotFoundException.
// 3. 비선형 자료구조이기 때문에 인덱싱을 사용할 수 없다.


// 딕셔너리는 해시 값에 의해 그 위치가 결정되므로 오름차순으로 정렬될 수 없다.
// 그래서 키와 밸류에 대하여 키를 기준으로 오름차순 정렬하는 자료구조를 제공한다.
// SortedList : 넌제네릭
// SortedList<KEY , VALUE> : 제네릭

class Collections3
{
    public static void Main()
    {
       
        Dictionary<string, string> color = new Dictionary<string, string>();

        color.Add("red", "빨간색");
        color.Add("green", "초록색");
        color.Add("blue", "파란색");

        foreach (var c in color) Console.WriteLine($"Key:{c.Key}, Value:{c.Value}");
        //foreach가 구현되어있다.

        color["red"] = "빨강";//수정
        color["yellow"] = "노랑"; //추가
        foreach (var c in color) Console.WriteLine($"Key:{c.Key}, Value:{c.Value}");


        SortedList<int, string> s1 = new SortedList<int, string>();
        s1.Add(3, "three");
        s1.Add(4, "four");
        s1.Add(1, "one");
        s1.Add(2, "two");

        foreach (var c in s1) Console.WriteLine($"Key:{c.Key}, Value:{c.Value}");
        //자동으로 정렬되어있음을 확인할 수 있다.
        string val;
        if (s1.TryGetValue(2, out val))
            Console.WriteLine(val);
        else Console.WriteLine("not found");

        Console.WriteLine(s1.ContainsKey(1));   //true
        Console.WriteLine(s1.ContainsKey(10));  //false

        Console.WriteLine(s1.ContainsValue("zero"));    //false

        s1.Remove(3);
        foreach (var c in s1) Console.WriteLine($"Key:{c.Key}, Value:{c.Value}");
    }
}

