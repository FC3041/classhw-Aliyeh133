
namespace LINQ_EX;

enum LifeExpectancyType {AtBirth, At60}
enum DataGender { Male, Female, Both}
class Data
{
    public Data(LifeExpectancyType leType, int year, string territory, string country, DataGender dg, double value)
    {
        LEType = leType;
        Year = year;
        Territory = territory;
        Country = country;
        DataGender = dg;
        Value = value;
    }

    public LifeExpectancyType LEType {get; }
    public int Year {get; }
    public string Terrirtory {get;}
    public string Country {get;}
    public DataGender DataGender {get;}
    public double Value {get;}
    public string Territory { get; }

    public override string ToString() =>
        $"{Country},{Year},{LEType},{DataGender},{Value}";

    public static Data Parse(string line)
    {
        var toks = line.Split(',').Select(t => t.Trim('"')).ToArray();        
        LifeExpectancyType leType = toks[0].Contains("60") ? 
                LifeExpectancyType.At60 :
                LifeExpectancyType.AtBirth;
        int year = int.Parse(toks[1]);
        string territory = toks[2].ToLower();
        string country = toks[3].ToLower();
        DataGender dg = toks[4].Contains("Both") ?
            DataGender.Both :
            (
                toks[4].Contains("Male") ? 
                    DataGender.Male :
                    DataGender.Female
            );
        double value = double.Parse(toks[5]);
        return new Data(leType, year, territory, country, dg, value);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Query 1");
        Console.WriteLine("--------------------------------------------------");
        File.ReadAllLines("data.csv")
            .Skip(1)
            .Where(l => l.ToLower().Contains("iran"))
            .Select(l =>
            {
                string[] tokens = l.Split(',');
                string hale = tokens[0];
                int year = int.Parse(tokens[1]);
                string country = tokens[3];
                string gender = tokens[4];
                double rate = double.Parse(tokens[5]);
                return (country,hale,gender,year,rate);
            })
            .Where(t =>(t.hale=="Healthy life expectancy (HALE) at birth (years)")&&(t.gender=="Both"))
            .OrderBy(t => t.rate)
            .ToList()
            .ForEach(l => Console.WriteLine(l));
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();


        Console.WriteLine("Query 2");
        Console.WriteLine("--------------------------------------------------");
        File.ReadAllLines("data.csv")
            .Skip(1)
            .Where(l => l.ToLower().Contains("iran"))
            .Select(l =>
            {
                string[] tokens = l.Split(',');
                string hale = tokens[0];
                int year = int.Parse(tokens[1]);
                string country = tokens[3];
                string gender = tokens[4];
                double rate = double.Parse(tokens[5]);
                return (country,hale,gender,year,rate);
            })
            .Where(t =>(t.hale=="Healthy life expectancy (HALE) at birth (years)")&&(t.gender=="Both"))
            .GroupBy(t => t.country)
            .Select(g =>
            {
                double max = g.Max(t => t.rate) ;
                double min = g.Min(t => t.rate) ;
                return (g.Key , diff:max-min) ;
            })
            .ToList()
            .ForEach(l => Console.WriteLine(l));
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();


        Console.WriteLine("Query 3");
        Console.WriteLine("--------------------------------------------------");
        int rank = 1 ;
        File.ReadAllLines("data.csv")
            .Where(l => l.Contains("Both"))
            .Where(l => l.Contains("at birth"))
            .Select(l =>
            {
                string[] tokens = l.Split(',');
                int year = int.Parse(tokens[1]);
                string country = tokens[3];
                double rate = double.Parse(tokens[5]);
                return (country,year,rate);
            })
            .GroupBy(t => t.country)
            .Select(g =>
            {
                double max = g.Max(t => t.rate) ;
                double min = g.Min(t => t.rate) ;
                int y = g.MinBy(t => t.rate).year ;
                return (country:g.Key , year:y , min:min , recovery:max-min);
            })
            .OrderByDescending(t => t.recovery)
            .ToList()
            .ForEach(l => Console.WriteLine((rank++).ToString()+l));
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();


        Console.WriteLine("Query 4");
        Console.WriteLine("--------------------------------------------------");
        var men_data = File.ReadAllLines("data.csv")
            .Where(l => l.Contains("at birth"))
            .Where(l => l.Contains("Male"))
            .Select(l =>
            {
                string[] tokens = l.Split(',');
                int year = int.Parse(tokens[1]);
                string country = tokens[3];
                double rate = double.Parse(tokens[5]);
                return (country,year,rate);               
            });

        var women_data = File.ReadAllLines("data.csv")
            .Where(l => l.Contains("at birth"))
            .Where(l => l.Contains("Female"))
            .Select(l =>
            {
                string[] tokens = l.Split(',');
                int year = int.Parse(tokens[1]);
                string country = tokens[3];
                double rate = double.Parse(tokens[5]);
                return (country,year,rate);               
            });

            int rankup = 0 ;
            women_data.Join(men_data ,
                            (w)=>(w.country,w.year) , 
                            (m)=>(m.country,m.year) , 
                            (w,m)=>(country:w.country , year:w.year , r1:m.rate , r2:w.rate , diff:Math.Abs(w.rate-m.rate))                       
                            )
            .GroupBy(t => t.country)
            .Select(g =>
            {
                var maxiff = g.MaxBy(t => Math.Abs(t.r2 - t.r1));
                return (g.Key , year:maxiff.year , r1:maxiff.r1 , r2:maxiff.r2 , diff:Math.Abs(maxiff.r2 - maxiff.r1));
            })
            .OrderByDescending(t => t.diff)
            .ToList()
            .ForEach(l => Console.WriteLine((rankup++).ToString()+l));
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine();

    }

    private static IEnumerable<object> GroupBy(Func<object, object> value)
    {
        throw new NotImplementedException();
    }
}
