package palindrome_chain_length.kyu7;

public class Palindromes {

	public static int palindromeChainLength(long n) {
		var answer = 0;
		while (!isPalindrome(n)) {
			n += Long.parseLong(new StringBuilder(String.valueOf(n)).reverse().toString());
			answer++;
		}
		return answer;
	}

	private static boolean isPalindrome(long m) {
		return String.valueOf(m).equals(new StringBuilder(String.valueOf(m)).reverse().toString());
	}

}
