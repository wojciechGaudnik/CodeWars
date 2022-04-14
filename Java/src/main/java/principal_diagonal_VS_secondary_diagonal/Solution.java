package principal_diagonal_VS_secondary_diagonal;

public class Solution {
	public static String diagonal(int[][] matrix) {
		var principal = 0;
		var secondary = 0;
		for (int p = 0, s = matrix.length - 1; p < matrix.length; p++, s--) {
			principal += matrix[p][p];
			secondary += matrix[p][s];
		}
		return (principal > secondary) ? "Principal Diagonal win!" : (principal == secondary) ? "Draw!" : "Secondary Diagonal win!";
	}
}
