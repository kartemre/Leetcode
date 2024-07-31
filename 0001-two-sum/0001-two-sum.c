/**
 * Note: The returned array must be malloced, assume caller calls free().
 */
int* twoSum(int* nums, int numsSize, int target, int* returnSize) {
    int* result = (int*)malloc(2 * sizeof(int));
    int temp;
    *returnSize = 2;

    for (int i = 0; i < numsSize - 1; i++)
    {
        temp = target;
        temp = temp - nums[i];
        for (int j = i + 1; j < numsSize ; j++)
        {
            if(temp == nums[j])
            {
                result[0] = i;
                result[1] = j;
                return result;
            }
        }
    }
    *returnSize = 0;
    return result;
}