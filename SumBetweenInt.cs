public class Solution {
    public long solution(int a, int b) {
        long sum = 0;
        
        if(a == b) return a;
        if(a > b) {
            while(a >= b){
                sum += b;
                b++;
            }
        } else {
            while(a <= b){
                sum += a;
                a++;
            }
        }
        
        return sum;
    }
}