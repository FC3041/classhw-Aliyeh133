public static class EXT
{
    public static string Encoder(this string str)
    {
        string new_str = "" ;
        if(str == null)
            return " " ;
        
        foreach(char c in str)
        {
            if(char.IsAsciiLetterUpper(c))
            {
                char x = char.ToLower(c);
                char new_c = EnChange(x) ;
                char xchang = char.ToUpper(new_c);
                new_str += xchang ;
            }

            else
            {
                new_str += EnChange(c) ;
            }
        }
        return new_str ;
    }


    public static string Decoder(this string str)
    {
        string new_str = "" ;
        if(str == null)
            return " " ;
        
        foreach(char c in str)
        {
            if(char.IsAsciiLetterUpper(c))
            {
                char y = char.ToLower(c);
                char new_c = DeChange(y) ;
                char ychange = char.ToUpper(new_c);
                new_str += ychange ;
            }

            else
            {
                new_str += DeChange(c) ;
            }
        }
        return new_str ;        
    }


    public static char EnChange(char c)
    {
        int ascii = (int)c ;
        int new_ascii = ascii + 3 ;
        if(new_ascii > 122)
        {
            int extra = new_ascii - 122 ;
            new_ascii = 96 + extra ;
        }
        char new_char = (char)new_ascii ;
        return new_char ;
    }

    public static char DeChange(char c)
    {
        int ascii = (int)c ;
        int new_ascii = ascii - 3 ;
        if(new_ascii < 97)
        {
            int extra = 97 - new_ascii ;
            new_ascii = 123 - extra ;
        }
        char new_char = (char)new_ascii ;
        return new_char ;
    }  
}