namespace S18;

class Program2
{
    delegate T _tow_number<T>(T a , T b);
    public static int add(int x , int y) => x + y ;
    public static double divide(double x , double y) => x/y ;
    // static void apply<T>(T[] nums0 , T[] nums1 , T[] result , _tow_number<T> fn)
    // {
    //     for(int i=0 ; i<nums0.Length ; i++)
    //         result[i] = fn(nums0[i] , nums1[i]);
    // }

    static void apply<T>(T[] nums0 , T[] nums1 , T[] result , Func<T,T,T> fn)
    {
        for(int i=0 ; i<nums0.Length ; i++)
            result[i] = fn(nums0[i] , nums1[i]);
    }

    static void dodo<T>(T[] values , Action<T> a)
    {
        foreach(var v in values)
            a(v) ;
    }

    static void Main(string[] args)
    {
        int[] nums0 = new int[3]{3,5,8};
        int[] nums1 = new int[3]{5,7,9};
        int[] result = new int[3];

        apply(nums0,nums1,result, (a,b) => a*b );
        dodo(result,Console.WriteLine);

        // for(int i=0 ; i<3 ; i++)
        //     Console.Write($"{result[i]} ");
        
    }

}