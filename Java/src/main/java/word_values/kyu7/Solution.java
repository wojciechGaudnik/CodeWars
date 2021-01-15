package word_values.kyu7;

public class Solution {

	public static int [] nameValue(String [] arr){
		var answer = new int[arr.length];
		for (var i = 0; i < arr.length; i++) {
			answer[i] = (int)arr[i].replaceAll(" ", "").chars().mapToLong(c -> c - 96).sum() * (i + 1);
		}
		return answer;
	}
}
