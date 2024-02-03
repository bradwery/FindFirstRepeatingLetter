namespace FindFirstRepeatingLetter;

public class FirstRepeatingLetter
{
    public static char ListContains(string source)
    {
        source = source.ToLower();
        List<char> foundChars = new List<char>();

        foreach(char c in source)
        {
            if(!char.IsLetter(c)) continue;
            if(foundChars.Contains(c)) return c;

            foundChars.Add(c);
        }

        return default;
    }

    public static char ForLoop(string source)
    {
        source = source.ToLower();

        for(int i = 0; i < source.Length; i++)
            for(int j = i + 1; j < source.Length; j++)
                if(source[i] == source[j]) return source[i];

        return default;
    }

    public static char BitFlag(string source)
    {
        source = source.ToLower();
        int bits = default;

        foreach(char c in source)
        {
            if(!char.IsLetter(c)) continue;

            int flag = 1 << (c - 'a');
            
            if((bits & flag) == flag) return c;
            bits |= flag;
        }

        return default;
    }
}
