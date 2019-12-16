using System;

class Int32
{
    public int val = 0;

    public static Int32 operator++(Int32 i) //이거 하나만 만들어도 알아서 전위형 후위형 동작해줌.
    {
        Int32 result = new Int32();
        result.val = i.val++;
        return result;
    }
    public static Int32 operator --(Int32 i) //이거 하나만 만들어도 알아서 전위형 후위형 동작해줌.
    {
        Int32 result = new Int32();
        result.val = i.val--;
        return result;
    }
}


namespace _1216
{
    class Operator_Overloading2
    {
        public static void Main1()
        {
            Int32 i = new Int32();
            Int32 j = i++;
            Console.WriteLine(i.val);
            Console.WriteLine(j.val);
            i.val = 0;

            //Int32 k = ++i;
            //Console.WriteLine(i.val);
            //Console.WriteLine(k.val); //뭔가 잘 안됨.
        }
    }
}
