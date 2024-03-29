package alphabet_symmetry.kyu7;

public class Solution {

	public static int[] solve(String[] arr) {
		var answer = new int[arr.length];
		for (var i = 0; i < arr.length; i++) {
			var sum = 0;
			for (var j = 0; j < arr[i].length(); j++) {
				if (Character.valueOf((char) (97 + j)).equals(Character.toLowerCase(arr[i].charAt(j)))) {
					sum++;
				}
			}
			answer[i] = sum;
		}
		return answer;
	}
}
   
