package All;

class Test
{
	// method to calculate gcd of two numbers
	static int gcd(int a, int b)
	{
		if (a == 0)
			return b;

		return gcd(b%a,a);
	}
	// method to calculate all common divisors
	// of two given numbers
	// a, b --> input integer numbers
	static int commDiv(int a,int b)
	{
		// find gcd of a,b
		int n = gcd(a, b);

		// Count divisors of n.
		int result = 0;
		for (int i=1; i<=Math.sqrt(n); i++)
		{
			// if 'i' is factor of n
			if (n%i==0)
			{
				// check if divisors are equal
				if (n/i == i)
					result += 1;
				else
					result += 2;
			}
		}
		return result;
	}

	// Driver method
	public static void main(String args[])
	{
		int a = 2, b = 3;
		System.out.println(commDiv(a, b));
	}
}
