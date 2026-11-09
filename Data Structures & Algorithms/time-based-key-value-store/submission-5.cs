public class TimeMap {

public Dictionary<string,List<Pair>> hash = new Dictionary<string,List<Pair>>();
    public TimeMap() {
        
    }
    
    public void Set(string key, string value, int timestamp) {
        var pair = new Pair() { TimeStamp = timestamp,Value = value };
        if( !hash.ContainsKey(key) ){
            hash.Add(key, new List<Pair>());
        }

            hash[key].Add(pair);
    }
    
    public string Get(string key, int timestamp) {        
        string result = "";

        if( hash.ContainsKey(key) ){

        List<Pair> pairs = hash[key];
        int high = pairs.Count - 1;
        int low = 0;

            while (low <= high){
                int mid = low + (high-low)/2;

                if( pairs[mid].TimeStamp <= timestamp ){
                    result = pairs[mid].Value;
                    low = mid + 1 ;
                }
                else {
                    high = mid - 1;
                }
            }
        }

        return result;
    }
}

public class Pair {
    public int TimeStamp;
    public string Value;
}
