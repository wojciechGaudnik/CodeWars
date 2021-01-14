package excessively_abundant_numbers.kyu7;

import java.util.LinkedList;

public class Kata {

	public static boolean abundantNumber(int n) {
		int i = 2;
		var list = new LinkedList<Integer>();
		while (i <= Math.sqrt(n)) {
			if (n % i == 0) {
				list.add(i);
				if (i != (n / i)) {
					list.add(n / i);
				}
			}
			i++;
		}
		return list.stream().mapToInt(Integer::intValue).sum() > n;
	}

}
