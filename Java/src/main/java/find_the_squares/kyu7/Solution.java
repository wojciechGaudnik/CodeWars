package find_the_squares.kyu7;

public class Solution {
	public static String findSquares(int y){
		return (long)Math.pow((y + 1) / 2, 2) + "-" + (long)Math.pow(((y + 1) / 2) - 1, 2);
	}
}
