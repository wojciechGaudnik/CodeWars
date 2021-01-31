package find_sum_of_top_left_to_bottom_right_diagonals.kyu7;

public class Diagonal {

	public static int diagonalSum(final int[][] matrix){
		var answer = 0;
		for (var i = 0; i < matrix.length; i++) {
			answer += matrix[i][i];
		}
		return answer;
	}
}
