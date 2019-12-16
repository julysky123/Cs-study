using System;

//인덱서(indexer): 객체를 배열처럼 보이게 하는 특수한 메서드.
class IntArray
{
    int[] arr;
    public IntArray(int size) { arr = new int[size]; }

    //인덱서 사용 방법
    // 접근제한자 원소의 타입 this[인덱스타입 변수명]
    //{
    //  get{
    //      return 값;
    //  }
    //  set {
    //      value를 사용하여 값을 저장
    //  }
    //}
    public int this[int idx] {
        get {return arr[idx]; }
        set { arr[idx] = value; }
    }
    public int this[string idx] {
        get {
            int i = Convert.ToInt32(idx);
            return arr[i];
        }
        set {
            int i = Convert.ToInt32(idx);
            arr[i] = value;
        }
    }

    //get이나 set 하나 없애면 각각 쓰기전용, 읽기전용 됨.
}

class MonthToDays
{
    int[] arr;
    public MonthToDays() { arr = new int[3] { 30, 31, 28 }; }
    public int this[string mon] {
        get {
            switch(mon)
            {
                case "Jan":
                case "Mar":
                case "May":
                case "Jul":
                case "Aug":
                case "Oct":
                case "Dec":
                    return arr[1];
                case "Fab": return arr[2];
                case "Apr":
                case "Jun":
                case "Nov":
                case "Sep":
                    return arr[0];
                default:
                    return -1;
            }
        }
    }
    public int this[int mon] {
        get {
            switch (mon)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return arr[1];
                case 2: return arr[2];
                case 4:
                case 6:
                case 9:
                case 11:
                    return arr[0];
                default:
                    return -1;
            }
        }
    }
}



class Operator_Overloading4
{
    public static void Main1()
    {
        IntArray arr = new IntArray(5);
        arr[4] = 2;
        arr["2"] = 3;
        Console.WriteLine(arr[4]);
        Console.WriteLine(arr[2]);

        MonthToDays days = new MonthToDays();
        for (int i = 1; i<13; i++)
        {
            Console.Write(days[i] + " ");
        }

        Console.WriteLine("\n"+days["Jan"]);
        
    }
}
