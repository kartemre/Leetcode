public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        if (strs == null || strs.Length == 0){
            return string.Empty;
        }
        string same = "";

        for (int i = 0; i < strs[0].Length; i++)
        {
            for (int j = 1; j < strs.Length ; j++)
            {
                if (i >= strs[j].Length || strs[j][i] != strs[0][i])
                    return same;
            }
            same += strs[0][i];
        }
        return same;
    }
}