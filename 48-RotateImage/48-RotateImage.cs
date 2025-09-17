// Last updated: 9/17/2025, 11:32:11 PM
public class Solution {
public void Rotate(int[][] matrix) {
    int left=0,right=matrix.Length-1; // Initialize left, right pointers for the outermost layer of the matrix
    while(left<right){ // Continue as long as there are layers to rotate, moving inward
        for(int i=0;i<right-left;i++){ // Iterate over the elements of the current layer's top row
            int top=left, bottom=right; // Define pointers for the top and bottom rows of the current layer, top is same as left and bottom is same as right because its a square matrix 

            // Store the top-left element of the current cycle of 4 elements to be rotated
            var topLeft=matrix[top][left+i]; // left+i because each element traverses using the i th iteration that runs for the entirity of the layer's square matrix horizontal length

            // Move the bottom-left element to the top-left position,bottom-i because we move up from bottomleft
            matrix[top][left+i] = matrix[bottom-i][left];

            // Move the bottom-right element to the bottom-left position right-i because we move left from bottom right
            matrix[bottom-i][left] = matrix[bottom][right-i];

            // Move the top-right element to the bottom-right position,top+i because we move down from top right
            matrix[bottom][right-i] = matrix[top+i][right];

            // Move the stored top-left element to the top-right position, from the temp variable
            matrix[top+i][right]=topLeft;
        }
        left++; // Move the left pointer inward to the next layer
        right--; // Move the right pointer inward to the next layer
        }
    }

    public void RotateEasyMethod(int[][] matrix) {
        int n = matrix.Length;

        // Transpose the matrix
        for (int i = 0; i < n; i++) {
            for (int j = i; j < n; j++) {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        // Reverse each row
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < n / 2; j++) { // only loop until first vertical half
                int temp = matrix[i][j];
                matrix[i][j] = matrix[i][n - 1 - j];
                matrix[i][n - 1 - j] = temp;
            }
        }
    }
}