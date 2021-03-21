package GCDsum.kyu7;

public class GCDsum {

	public static int[] solve(int s, int g){
		for (int a = s, b = 0; a >= b; a--, b++) {
			if (gcd(a, b) == g) {
				return new int[]{Math.min(a, b), Math.max(a, b)};
			}
		}
		return new int[]{-1, -1};
	}

	static int gcd(int a, int b)	{
		if (a == 0)	return b;
		return gcd(b % a, a);
	}
}
