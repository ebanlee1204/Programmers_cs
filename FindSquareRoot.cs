using System;

public class Solution {
    public long solution(long n) {
        long i = 1;
        
        while(i <= n){
            if(i*i == n) return (i+1)*(i+1);
            if(n/i < i) return -1;
            i++;
        }
        
        return -1;
    }
}