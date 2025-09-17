// Last updated: 9/17/2025, 9:32:38 PM
public class Solution {
    public int[][] Transpose(int[][] matrix) {
        var transpose=new int[matrix[0].Length][];
        
        for(int c=0;c<matrix[0].Length;c++){
            transpose[c] = new int[matrix.Length];
            for(int r=0;r<matrix.Length;r++){
                transpose[c][r]=matrix[r][c];
            }
        }
        return transpose;
    }

    public int[][] TransposeSquareMatrixInPlace(int[][] matrix) {
        for(int r=0;r<matrix.Length;r++){
            for(int c=r+1;c<matrix.Length;c++){
                var temp=matrix[r][c];
                matrix[r][c]=matrix[c][r];
                matrix[c][r]=temp;
            }
        }
        return matrix;
    }
}