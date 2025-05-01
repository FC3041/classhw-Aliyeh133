namespace S18;

class Program2
{
    delegate T _tow_number<T>(T a , T b);
    public static int add(int x , int y) => x + y ;
    public static double divide(double x , double y) => x/y ;
    static void apply<T>(T[] nums0 , T[] nums1 , T[] result , _tow_number<T> fn)
    {
        for(int i=0 ; i<nums0.Length ; i++)
            result[i] = fn(nums0[i] , nums1[i]);
    }
    static void Main(string[] args)
    {
        double[] nums0 = new double[3]{3,5,8};
        double[] nums1 = new double[3]{5,7,9};
        double[] result = new double[3];

        apply(nums0,nums1,result,divide);

        for(int i=0 ; i<3 ; i++)
            Console.Write($"{result[i]} ");
        
    }

}