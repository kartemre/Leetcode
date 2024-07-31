public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 1;
        foreach (int n in nums)
        {
            if(nums [k-1] != n)
            {
                nums[k] = n; 
                k++;
            }
        }
        return k;
    }
}