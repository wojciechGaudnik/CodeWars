package the_fusc_function_part_1.kyu7;

public class Kata {
	public static void main(String[] args) {
		System.out.println(fusc(85));
	}

	public static int fusc(int n) {
		if (n == 1) {
			return 1;
		} else if (n != 0 && n % 2 == 0) {
			return fusc(n / 2);
		} else if (n % 2 != 0) {
			return fusc(n / 2) + fusc(n / 2 + 1);
		}
		return 0;
	}
}
