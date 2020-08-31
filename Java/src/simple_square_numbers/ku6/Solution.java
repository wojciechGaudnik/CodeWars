package simple_square_numbers.ku6;

public class Solution {

	public static long solve(int n){
		var answer = 1;
		while (answer < n && Math.sqrt(Math.pow(answer, 2) + n) % 1 != 0) {
			answer++;
		}
		return (answer < n)? (long)Math.pow(answer, 2): -1;
	}
}
   
