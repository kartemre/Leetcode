public class Solution {
    public static int closestNumber (List<int> numbers, int target)
    {
        if (numbers.Count == 0)   throw new ArgumentException("Liste boş olamaz.");

        int closestValue = numbers[0];
        int minDifference = Math.Abs(target - closestValue);

        foreach (int number in numbers) {
            int currentDifference = Math.Abs(target - number);

            if (currentDifference < minDifference) {
                minDifference = currentDifference;
                closestValue = number;
            }
        }
        return closestValue; 
    }
    
    public int ThreeSumClosest(int[] nums, int target) {
        Array.Sort(nums);
        List<int> numbers = new List<int>();

        for (int i = 0; i < nums.Length - 2 ;i++)
        {
            if (i>0 && nums[i] == nums [i - 1]) continue;
            int right = nums.Length - 1;
            int left = i + 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];
                numbers.Add(sum);
                if (sum < target) {
                    left++; 
                } else if (sum > target) {
                    right--; 
                } else {
                    return sum;
                }
            }
        }
        int res = closestNumber(numbers,target);
        return res;
    }
}