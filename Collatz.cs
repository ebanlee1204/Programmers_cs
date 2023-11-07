public class Solution {
    public int solution(int n) {
        
        long n_long = (long)n;
        
        int i = 0;
        if(n_long == 1) return 0;
        
        while(i < 500){
            if(n_long == 1) return i;
            if(n_long % 2 == 0){
                n_long /= 2;
                i++;
                continue;
            }
            n_long = n_long * 3 + 1;
            i++;
        }
        return -1;
    }
}