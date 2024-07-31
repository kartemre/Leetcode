public class Solution {
    public bool IsValid(string s) {
        Stack<char> parent = new Stack<char>();
        foreach(char n in s)
        {
            if(n == '(' || n == '[' || n == '{')
            {
                parent.Push(n);
            }
            else if(n == ')' || n == ']' || n == '}')
            {
                if (parent.Count == 0)
                    return false;

                char top = parent.Pop();
                if (!(top == '(' && n == ')' || top == '[' && n == ']' || top == '{' && n == '}'))
                {
                    parent.Push(top);
                    parent.Push(n);
                }
            }
        }
        return parent.Count == 0;
    }
}