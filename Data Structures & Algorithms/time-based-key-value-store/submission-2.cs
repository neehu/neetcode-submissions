public class TimeMap {
public Dictionary<string,List<Pair>> hash = new Dictionary<string,List<Pair>>();

    public TimeMap() {
        
    }

    
    public void Set(string key, string value, int timestamp) {
        var pair = new Pair(){ TimeStamp = timestamp,Value = value};
        if(! hash.ContainsKey(key)){
            hash.Add(key,new List<Pair>());
        }
        hash[key].Add(pair);
    }
    
    public string Get(string key, int timestamp) {
        string result = "";

        if(hash.ContainsKey(key)){
            int low = 0;
            int high = hash[key].Count - 1;
            var values = hash[key];
            
            while(low <= high){
                int mid = low + (high-low)/2;
                
                if(values[mid].TimeStamp <= timestamp){
                    result = values[mid].Value;
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
