package vasya_and_system_of_equations.ky6;

public class SystemOfEq {

	public static void main(String[] args) {
		System.out.println(Solution(14, 28));
	}

	public static int Solution(int n, int m)
	{
		var a = 0;
		var b = 0;
		for (a = 0; Math.pow(a, 2) + b < 1000; a++) {
			for (b = 0; Math.pow(b, 2) + a < 1000; b++) {
				if (Math.pow(a, 2) + b == n && Math.pow(b, 2) + a == m) {
					return 1;
				}
			}
		}
		return 0;
	}
}
   
