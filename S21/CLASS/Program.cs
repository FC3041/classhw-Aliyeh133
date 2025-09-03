namespace CLASS;

public static class EXT
{
    public static IEnumerable<T> MyTake<T>(this IEnumerable<T> source , int count)
    {
        List<T> values = new List<T>();
        foreach(var item in source)
        {
            if(values.Count() < count)
                values.Add(item);
            else 
                break ;
        }
        return values ;
    }

    public static IEnumerable<T> MyTake2<T>(this IEnumerable<T> source , int count)
    {
        foreach(var item in source)
        {
            if(count-- > 0)
                yield return item ;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var data = File.ReadAllLines("children-per-woman-UN.csv")
                       .Skip(1)
                       .Select(l =>
                       {
                           string[] tokens = l.Split(',');
                           string country = tokens[0];
                           int year = int.Parse(tokens[2]);
                           double rate = double.Parse(tokens[3]);
                           return (country,year,rate);
                       });

        data.Join(data ,
                 (d1)=>(d1.country,d1.year) , //this is the key of its line
                 (d2)=>(d2.country,d2.year-1) , //this is the key of its line
                 // these keys should be same to choose !
                 (d1,d2)=>(country:d1.country , y1:d1.year , y2:d2.year , r1:d1.rate , r2:d2.rate)
                 )

        .GroupBy(t => t.country)
        .Select(g =>
        {
            var maxiff = g.MaxBy(t => Math.Abs(t.r2 - t.r1));
            return (country:g.Key , diff:Math.Abs(maxiff.r2 - maxiff.r1));
        })
        .OrderBy(t => t.diff)
        .ToList()
        .ForEach(l => Console.WriteLine(l));
    }           

    static void Main1(string[] args)
    {
        // string[] lines = 
        File.ReadAllLines("children-per-woman-UN.csv")
            .Skip(1)
            // .Where(l => l.ToLower().Contains("iran"))
            .Select(l =>
            {
                string[] tokens = l.Split(',');
                string country = tokens[0];
                int year = int.Parse(tokens[2]);
                double rate = double.Parse(tokens[3]);
                return (country,year,rate);
            })
            .GroupBy(t => t.country)
            .Select(g =>
            {
                return (g.Key , rate:g.Average(t => t.rate));
            })
            // .Where(t => (t.year>2012)&&(t.rate>3))
            .OrderBy(t => t.rate)
            // .Take(5)
            .ToList()
            .ForEach(l => Console.WriteLine(l));

        // foreach(var item in lines.MyTake2(10))
        //     Console.WriteLine(item);
    }

    public static IEnumerable<string> GetNames()
    {
        yield return "ali" ;
        yield return "aram" ;
    }

    static void Main0(string[] args)
    {
        foreach(var item in GetNames())
            System.Console.WriteLine(item);
    }
}
