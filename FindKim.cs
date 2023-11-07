public class Solution {
    public string solution(string[] seoul) {
        string answer = "";
        int i = 0;
        foreach(string element in seoul){
            if(element == "Kim") answer = "김서방은 " + i + "에 있다";
            i++;
        }
        
        
        return answer;
    }
}