class Map<K,V>{
    public ISet<K> keys { set; get; }
    public IList<V> values { set; get; }

    public IDictionary<K,V> myDict()
    {
        IDictionary<K, V> dict = new Dictionary<K, V>();
        int i = 0;
        foreach(K key in keys)
            dict.Add(key, values[i++]); 

        return dict;  
    }
    
}
