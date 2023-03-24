namespace Project;
class Program
{
    static void Main(string[] args)
    {
       Console.Clear();
       int countOfSymbols = 3;
       string[] resource = {"hello", "2","world",":-("};
       System.Console.WriteLine(String.Join(",",resource));
        System.Console.WriteLine($"[{String.Join(", ",resource)}] => [{String.Join(", ",GetRangedSymbolsWords(resource,countOfSymbols))}]");
    }

    static string[] GetRangedSymbolsWords(string[] resource,int countOfSymbols){
        string[] result = new string[resource.Length];
        int j = 0;
        for (int i = 0; i < resource.Length; i++)
        {
            int tmpValue = result[i].Length;
            if (tmpValue < countOfSymbols ) {
                result[j] = result[i];
            }
        }
        return result;

    }
}
