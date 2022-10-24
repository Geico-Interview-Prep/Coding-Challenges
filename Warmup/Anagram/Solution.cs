namespace Anagram;

public class Solution
{
    public Boolean IsAnagram(string s1, string s2) {
        if (s1.Length != s2.Length) return false;

        char[] arr1 = s1.ToCharArray();
        char[] arr2 = s2.ToCharArray();

        Array.Sort(arr1);
        Array.Sort(arr2);
        
        for (int i = 0; i < arr1.Length; i++) {
            if (arr1[i] != arr2[i]) return false;
        }

        return true;
    }
}