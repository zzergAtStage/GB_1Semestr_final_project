namespace Project;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int countOfSymbols = 3;
        string[] resource = { "hello", "2", "world", ":-(" };
        System.Console.WriteLine($"[{String.Join(", ", resource)}] => [{String.Join(", ", GetRangedSymbolsWords(resource, countOfSymbols))}]");
    }

    static string[] GetRangedSymbolsWords(string[] resource, int countOfSymbols)
    {
        string[] result = new string[resource.Length];
        int j = 0;
        for (int i = 0; i < resource.Length; i++)
        {
            int tmpValue = resource[i].Length;
            if (tmpValue <= countOfSymbols)
            {
                result[j] = resource[i];
                j++;
            }
        }
        Array.Resize<string>(ref result,j); 
        return result;

    }
    static string PrintArray(string[] pArray, int pos = 0)
    {
        string result = String.Empty;

        if (pos >= pArray.Length) { return String.Empty; }
        else
        {
            return result = ", " + pArray[pos]  + PrintArray(pArray, pos + 1);
        }

    }
}
