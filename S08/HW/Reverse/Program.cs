namespace Reverse;

class Program
{
    public static void reverse_all_chars(string s , out string sout)
    {
        sout = "" ;
        foreach(char c in s)
            sout = c + sout ;
    }


    public static void reverse_words(string s , out string sout)
    {
        sout = "" ;
        for(int i=s.Length-1 ; i>=0 ; i--)
        {
            if( s[i] == ' ' )
            {
                for(int j=i+1 ; j < s.Length  &&  s[j] != ' ' ; j++)
                    sout += s[j]  ;
                sout += ' ' ;
            }

            if( i==0 )
            {
                for(int k=0 ; s[k] != ' ' ; k++)
                    sout += s[k] ;
            }
        }
    }

    static void Main(string[] args)
    {
        string sen = "hello it is me" ;
        string sout ;
        reverse_all_chars(sen , out sout);
        System.Console.WriteLine(sout);

        reverse_words(sen , out sout);
        System.Console.WriteLine(sout);
    }
}
