public class Solution {
    public bool solution(int x) {
        
        int temp = x;
        int sum = 0;
        
        // 자릿수 합 구하기 
        while(temp > 0){
            sum += temp % 10;
            temp /= 10;
        }
        
        // 나누어 떨어지는지 확인
        if(x % sum == 0) return true;
        
        return false;
    }
}