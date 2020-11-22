package simple_directions_reversal.kyu7;

import java.util.Arrays;

public class Solution {

	public static void main(String[] args) {
		System.out.println(Arrays.toString(solve(new String [] {"Begin on Road A","Right on Road B","Right on Road C","Left on Road D"})));
	}


	public static String [] solve(String [] arr){
		var answer = new String[arr.length];
		for (int i = 0, j = arr.length - 1; i < arr.length; i++, j--) {
			if (i == 0) answer[i] = "Begin on " + arr[j].split(" on ")[1];
			else {
				var direction = (arr[j + 1].split(" on ")[0].equals("Right"))? "Left": "Right";
				var road = arr[j].split(" on ")[1];
				answer[i] = direction + " on " + road;
			}
		}
		return answer;
	}
}
