public class TimeMap {

 Dictionary<string,List<Pair>> hash = new Dictionary<string,List<Pair>>();

    public TimeMap() {
        
    }
    
    public void Set(string key, string value, int timestamp) {
        var pair = new Pair() { Value = value, TimeStamp = timestamp};
        if(!hash.ContainsKey(key)){
            hash.Add(key,new List<Pair>());
        }
        hash[key].Add(pair);
    }
    
    public string Get(string key, int timestamp) {
        string result = "";

        if(hash.ContainsKey(key)){
            var pairs = hash[key];
            int low = 0 ;
            int high = pairs.Count - 1;

            while (low <= high ){
                int mid = low + (high - low)/2;

                if( pairs[mid].TimeStamp <= timestamp ){
                    result = pairs[mid].Value;
                    low = mid + 1;
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
