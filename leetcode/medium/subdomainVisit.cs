public class Solution {
    public IList<string> SubdomainVisits(string[] cpdomains) {
        Dictionary<string, int> visits = new Dictionary<string, int>();
        int i=0;
        foreach (var word in cpdomains){
            var index = word.IndexOf(' ');
            var domain = word.Substring(index+1);
            var visit = int.Parse(word.Substring(0,index));
            while(true){
                if(visits.TryGetValue(domain, out int value)){
                   visits[domain]=visits[domain]+visit; 
                }
                else{
                     visits.Add(domain, visit);
                }
                index = domain.IndexOf('.');
                if(index<0){
                    break;
                }
                domain = domain.Substring(index+1);
            }
            
        }
        var resultSet=new List<string>();
        foreach (var kvp in visits){
            var result = kvp.Value.ToString() + " " + kvp.Key;
            resultSet.Add(result);
        }
        return resultSet;
    }
}
// 811. Subdomain Visit Count
