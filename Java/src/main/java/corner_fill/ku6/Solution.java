package corner_fill.ku6;

class Solution {

	public static int[] cornerFill(int[][] square) {
		var turn = true;
		var answer = new int[(int) Math.pow(square.length, 2)];
		var answerIndex = 0;
		while (square.length > 0) {
			var temp = new int[(square.length * 2) - 1];
			var tempIndex = 0;
			var y = 0;
			for (var x = 0; x < square.length; x++) {
				System.out.println(square[y][x]);
				temp[tempIndex++] = square[y][x];
			}
			var x = square.length - 1;
			for (y = 1; y < square.length; y++) {
				System.out.println(square[y][x]);
				temp[tempIndex++] = square[y][x];
			}
			if (turn) {
				for (var one : temp) {
					answer[answerIndex++] = one;
				}
			} else {
				temp = reverse(temp);
				for (var one : temp) {
					answer[answerIndex++] = one;
				}
			}

			turn = !turn;
			square = cut(square);
		}
		return answer;
	}

	private static int[][] cut(int[][] square) {
		var answer = new int[square.length - 1][square.length - 1];
		for (var y = 1; y < square.length; y++) {
			for (var x = 0; x < square.length - 1; x++) {
				answer[y - 1][x] = square[y][x];
			}
		}
		return answer;
	}

	public static int[] reverse(int[] arr) {
		var answer = new int[arr.length];
		for (int s = 0, e = arr.length - 1; s < arr.length; s++, e--) {
			answer[e] = arr[s];
		}
		return answer;
	}

}
