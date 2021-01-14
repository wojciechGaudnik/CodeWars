package square_matrix_multiplication.kyu5;

public class Kata {
	public static int[][] matrixMultiplication(int[][] a, int[][] b) {
		int[][] answer = new int[a.length][b[0].length];
		for (var y = 0; y < answer.length; y++) {
			for (var x = 0; x < answer[0].length; x++) {
				for (int i = 0; i < b.length; i++) {
					answer[y][x] += a[y][i] * b[i][x];
				}
			}
		}
		return answer;
	}
}
