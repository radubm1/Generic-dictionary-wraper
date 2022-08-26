class Test {
    public static void Main(String[] args)
    {
        IList<string> my_lst = new List<string>();
        foreach (String s in args)
            my_lst.Add(s);

        ISet<int> my_set = new HashSet<int>();
        my_set.Add(1); my_set.Add(2); my_set.Add(3);

        Map<int, string> my_dict = new Map<int, string>() { keys = my_set, values = my_lst };

        IDictionary<int, string> dict = my_dict.myDict();

        foreach (var pair in dict)
        {
            Console.WriteLine($"Element with key {pair.Key}: Id={pair.Value}");
        }
    }
};