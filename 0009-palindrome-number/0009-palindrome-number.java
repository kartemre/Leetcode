class Solution {
    public boolean isPalindrome(int x) {
        String strNum = Integer.toString(x);
        char[] charArray = strNum.toCharArray();

        for(int i = 0; i < strNum.length() / 2; i++){
            if (charArray[i] != charArray[charArray.length - 1 - i]){
                return false;
            }
        }
        return true;
    }
}