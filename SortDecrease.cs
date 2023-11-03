using System;
using System.Collections.Generic;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        List<long> n_list = new List<long>();
        
        while(n > 0){
            n_list.Add(n % 10);
            n /= 10;
        }
        
        n_list.Sort();
        n_list.Reverse();
        
        foreach (long entry in n_list)
        {
            answer = 10 * answer + entry;
        }
        
        return answer;
    }
}