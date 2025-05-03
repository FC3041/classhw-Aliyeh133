public static class EXT //it is static because there is no need to make an object !
{
    public static string TitleCase(this string str)
    {
        if(str == null)
            return " " ;
        return char.ToUpper(str[0])+str.Substring(1);
    }

    public static int NumberOfNums(this string str)
    {
        if(str == null)
            return 0 ;
        
        int count = 0 ;
        foreach(char c in str)
        {
            if(char.IsDigit(c))
                count++ ;
        }
        return count ;
    }
}