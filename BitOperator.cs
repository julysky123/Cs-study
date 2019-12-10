
class BitOperator
{
    public static void Main1()
    {
        //비트연산
        //&,|,^,~,<<,>>

        //& bit and
        //| bit or
        //^ bit xor
        //~ bit not
        //<< left shift
        //>> right shift


        byte b = 10; //0000 1010
        System.Console.WriteLine(~b); //1111 0101
        System.Console.WriteLine(System.Convert.ToString(b, 16));       //16진수로
        System.Console.WriteLine(System.Convert.ToString(~b, 16));      //16진수로. 2, 8, 16가능
    }
}

