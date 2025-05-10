namespace S19;

class Program
{
    public delegate int BinaryOp(int a , int b);
    public delegate void LogFn(string msg);
    // public static LogFn Log = Console.WriteLine ;
    public static event LogFn Log ;

    static int[] apply(int[] nums1, int[] nums2, BinaryOp op)
    {
        int[] result = new int[nums1.Length];
        for(int i=0 ; i<nums1.Length ; i++)
            result[i] = op(nums1[i] , nums2[i]);
        return result ;
    }

    static void LogToFile(string msg)
    {
        File.AppendAllText("log.txt", msg);
    }

    static int add(int a,int b) => a+b ;

    static void Main1(string[] args)
    {
        Log += Console.WriteLine ;
        Log += LogToFile ;

        string s = null ;
        string name = s ?? "Ted" ;
        string name1 = s != null ? s : "Liana" ;

        int[] nums1 = new int[3]{1,5,8};
        int[] nums2 = new int[3]{5,9,10};
        int[] result = apply(nums1,nums2,add);
        foreach(var r in result)
            Log?.Invoke(r.ToString()+ " ");

        Log -= Console.WriteLine ;
        Log += msg => Console.WriteLine($"SMS: +989129991234 {msg}"); // here we added a function , so next inputs will write
                                                                      // in this format !
        // BinaryOp op1 = (a , b) => a*2 - b ;

        int[] result1 = apply(nums1,nums2,(a,b)=>a*b-2);
        foreach(var r1 in result1)
            Log?.Invoke(r1.ToString() + " ");  
            // writing only r in console but writing r and r1 in file . why? because we remove Console.WriteLine from
            // the list of function pointers !

    }
}
