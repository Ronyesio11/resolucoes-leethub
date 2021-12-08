public class Solution {
    public string RestoreString(string s, int[] indices) {
        char[] newS = s.ToCharArray();
        for (int i = 0; i < indices.Length; i++){
        for (int j = i+1; j < indices.Length; j++){
            if (indices[i] > indices[j]){
            
            char n = newS[i];
            newS[i] = newS[j];
            newS[j] = n;
            int c = indices[i];
            indices[i] = indices[j];
            indices[j] = c;

        }

    }
}
s = new string(newS);
        return s;
    }
}