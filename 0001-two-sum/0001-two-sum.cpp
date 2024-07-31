#include<iostream>
using namespace std;

class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        
        unordered_map<int,int> hash_table;

        for (int i = 0 ; i < nums.size() ; i++){ 
            int x = nums[i];
            int y = target - x;
            if (hash_table.count(y)){
                if(hash_table[x]>hash_table[y]){
                    if(i>hash_table[x]){
                        return {hash_table[x], i};
                    }
                    else{
                        return {i, hash_table[x]};
                    }
                }
                else{
                     if(i>hash_table[y]){
                        return {hash_table[y], i};
                    }
                    else{
                        return {i, hash_table[y]};
                    }
                }    
            }
            hash_table[x] = i;

        }
        return{-1,-1};
    }
};