package All;

class Test {
	static int gcd(int a, int b) {
		if (a == 0)
			return b;

		return gcd(b % a, a);
	}

	static int commDiv(int a, int b) {
		int n = gcd(a, b);

		int result = 0;
		for (int i = 1; i <= Math.sqrt(n); i++) {
			if (n % i == 0) {
				if (n / i == i)
					result += 1;
				else
					result += 2;
			}
		}
		return result;
	}

}
