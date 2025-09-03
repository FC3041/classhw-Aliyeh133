using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace E3;

public class Animal
{
    public virtual string MakeSound() => "Some generic animal sound";
}

public class Dog : Animal
{
    public override string MakeSound() => "Woof";
}


// public class Comparer<T> : IComparable<T>
// {
//     public T Value1 { get; set; }
//     public T Value2 { get; set; }
//     public Comparer(T value1, T value2)
//     {
//         Value1 = value1;
//         Value2 = value2;
//     }

//     public int CompareTo(T other)
//     {
//         return Value1.CompareTo(other.Value1);
//     }
// }


public class ResourceManager : IDisposable
{
    public bool IsDisposed { get; set; }

    public void Dispose()
    {
        IsDisposed = true;
    }
}

public static class LinqProblems
{
    public static List<int> FilterAndDouble(List<int> list)
    {
        var newlist = list.Where(i => i % 2 == 0 && i > 5)
                          .Select(i => 2 * i)
                          .ToList();

        return newlist;
    }

    // public static Dictionary<string t1, int t2> GetTotalAmountByCategory(List<Sale> list)
    // {
    //     var total = list.GroupBy(s => s.Category)
    //                     .Select(g =>  g.Sum(i => i.Amount))
    //                     .ToList();
    //     return total;
    // }
}

public class Sale
{
    public string Category { get; set; }
    public int Amount { get; set; }
}

public class Money : IEquatable<Money>
{
    public int Amount;
    public string U;

    public Money(int v1, string v2)
    {
        Amount = v1;
        U = v2;
    }

    public static Money operator +(Money m1, Money m2)
    {
        return new Money(m1.Amount + m2.Amount, m1.U);
    }

    public static bool operator ==(Money m1, Money m2)
    {
        return m1.Amount == m2.Amount;
    }

    public static bool operator !=(Money m1, Money m2)
    {
        return m1.Amount != m2.Amount;
    }

    public bool Equals(Money m)
    {
        return Amount == m.Amount;
    }
}

public delegate string StringOperation(string s);
public static class DelegateProblems
{
    public static string ProcessString(string str, StringOperation fn)
    {
        return fn(str);
    }

    public static string ToUpper(string str)
    {
        return str.ToUpper();
    }

    public static string ToLower(string str)
    {
        return str.ToLower();
    }
}

public class LambdaProblems
{
    public static Func<string, int> GetStringLengthCalculator()
    {
        return (s) => s.Length;
    }
}
