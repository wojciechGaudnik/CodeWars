package fibonacci.kyu7;

public class Fibonacci {

	public static long fib (int n){
		long a = 0;
		long b = 1;
		for (var i = 0; i < n; i++) {
			long temp = b;
			b += a;
			a = temp;
		}
		return a;
	}
}
