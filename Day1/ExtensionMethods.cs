static class ExtensionMethods
{
    public static List<int> MovingWindowSum(this List<int> list, int n)
    {
        var condensed = new List<int>();
        for (var i = 0; i < list.Count; i++)
        {
            var window = list.Skip(i).Take(n).ToList();
            if (window.Count < n)
            {
                continue;
            }
            Console.WriteLine($"{window} = {window.Sum()}");
            condensed.Add(window.Sum());
        }
        return condensed;
    }
}