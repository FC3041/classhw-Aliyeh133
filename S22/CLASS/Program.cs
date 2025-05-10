using System.Runtime.InteropServices;

namespace CLASS;

class Program
{
    static bool IsOdd(int a)
    {
        return a%2 == 1 ;
    }

    static string L2S(IEnumerable<int> nums)
    {
        return string.Join(" ",nums);
    }

    static double ODD(IEnumerable<int> nums)
    {
        int count = 0 ;
        foreach(int a in nums)
        {
            if(a%2 == 1) 
                count += a ;
        }
        return count/5 ;
    }

    static bool IsPrime(int a)
    {
        for(int i=2 ; i<a ; i++)
            if(a%i == 0)
                return false ;
        return true ;
    }


    static void Main(string[] args)
    {
        // Enumerable.Range(0,100)
        //           .Where(IsOdd)
        //           .ToList()
        //           .ForEach(Console.WriteLine);


        // Enumerable.Range(1,100)
        //           .GroupBy(x => x/10)
        //         //   .Select(ig => L2S(ig)) // .Select(L2S) // .Select(ig => string.Join(" ",ig))
        //           .Select(g => 
        //           {
        //             return (g.Key , ODD(g));
        //           }) // .Select( ig => (ig.Key , ig.Where(x => x%2 == 1).Average()) )
        //           .ToList()
        //           .ForEach(l => Console.WriteLine(l));

        // Enumerable.Range(1,100)
        //           .Where(x => IsPrime(x))
        //           .ToList()
        //           .ForEach(Console.WriteLine);

        var data = Enumerable.Range(1,100)
                  .Where(x => IsPrime(x))
                  .Select( x => (number:x , sum:x.ToString().Select(c => c-48).Sum()) );

        data.Join(data ,(d1)=>(d1.sum),(d2)=>(d2.sum),(d1,d2)=>(d1.number,d2.number,d1.sum))
            .Where(t => t.Item1 != t.Item2)
            // .DistinctBy(t => (n1,n2,key) =>
            // {
            //     if(n1 < n2)
            //         return (n1,n2);
            //     return (n2,n1);
            // })
            .ToList()
            .ForEach(l => Console.WriteLine(l));
    }
}
