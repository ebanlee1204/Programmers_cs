public class Solution {
    public int solution(int n) {
        
        int i = 0;
        if(n == 1) return 0;
        
        while(i < 500){
            if(n == 1) return i;
            if(n % 2 == 0){
                n /= 2;
                i++;
                continue;
            }
            n = n * 3 + 1;
            i++;
        }
        return -1;
    }
}