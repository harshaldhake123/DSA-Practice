// Last updated: 9/29/2025, 10:13:47 PM
public class Solution {
    public void Rotate(int[][] matrix) {
        // transpose then reverse
        for(var r=0;r<matrix.Length;r++){
            for(var c=r;c<matrix.Length;c++){
                var temp=matrix[r][c];
                matrix[r][c]=matrix[c][r];
                matrix[c][r]=temp;
            }
        }
        for(var r=0;r<matrix.Length;r++){
            for(var c=0;c<matrix.Length/2;c++){
                var temp=matrix[r][c];
                matrix[r][c]=matrix[r][matrix.Length-c-1];
                matrix[r][matrix.Length-c-1]=temp;
            }
        }
    }
}