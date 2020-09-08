package factorial.kyu7;

public class Factorial {

	public int factorial(int n) {
		if (n < 0 || n > 12) {
			throw new IllegalArgumentException();
		} else if (n == 0) {
			return 1;
		}
		return n * factorial(n - 1);
	}
}
   
