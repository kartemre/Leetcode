public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> res = new List<IList<int>>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length - 2; i++){
            if (i > 0 && nums[i] == nums[i-1]) continue;
            
            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[left] + nums[right] + nums[i];
                if(sum > 0)
                    right--;
                else if (sum < 0)
                    left++;
                else
                {
                    res.Add(new List<int> { nums[i], nums[left], nums[right]});
                    while(left < right && nums[left] == nums[left+1]) left++;
                    while(left < right && nums[right] == nums[right-1]) right--;
                    left++;
                    right--;
                }                   
            }                
        }
        return res;
    }
}