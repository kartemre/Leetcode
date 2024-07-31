import java.util.Hashtable;

class Solution {
    public int romanToInt(String s) {
        
        Hashtable<String, Integer> table = new Hashtable<>(7);

        int counter = 0;
        String control;
        table.put("I", 1);
        table.put("V", 5);
        table.put("X", 10);
        table.put("L", 50);
        table.put("C", 100);
        table.put("D", 500);
        table.put("M", 1000);

        char[] charArr = s.toCharArray();

        for(int i = 0; i < s.length() - 1; i++){
            control = String.valueOf(charArr[i]);
            if (table.containsKey(control)){
                if (table.containsKey(String.valueOf(charArr[i+1]))){
                    if (table.get(control) >= table.get(String.valueOf(charArr[i+1]))){
                        counter += table.get(control);
                    }
                    else{
                        counter -= table.get(control);
                    }
                }
            }
        }
        control = String.valueOf(charArr[s.length() - 1]);
        if (table.containsKey(control)){
            counter += table.get(control);
        }
        return counter;
    }
}