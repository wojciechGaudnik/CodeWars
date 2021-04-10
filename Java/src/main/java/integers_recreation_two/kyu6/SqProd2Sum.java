package integers_recreation_two.kyu6;

import java.util.Arrays;
import java.util.LinkedList;
import java.util.List;
import java.util.stream.Collectors;

public class SqProd2Sum {
	public static void main(String[] args) {
//		prod2Sum(2, 3, 4, 5).forEach(e -> System.out.println(Arrays.toString(e)));
//		prod2Sum(1, 2, 1, 3).forEach(e -> System.out.println(Arrays.toString(e)));
//		prod2Sum(2, 3, 4, 5).forEach(e -> System.out.println(Arrays.toString(e)));
//		prod2Sum(10, 11,12 , 13).forEach(e -> System.out.println(Arrays.toString(e)));
		prod2Sum(1, 20, -4, -5).forEach(e -> System.out.println(Arrays.toString(e)));
	}

	public static List<long[]> prod2Sum(long a, long b, long c, long d) {
//		if (a < 0 || b < 0 || c < 0 || d < 0) {
//			return new LinkedList<>(){{
//				add(new long[2]);
//				add(new long[2]);
//			}};
//
//
//		}
		var answer = new LinkedList<long[]>();
//		System.out.println(a + " " + b + " " + c + " " + d);
		var number = (Math.pow(a, 2) + Math.pow(b, 2)) * (Math.pow(c, 2) + Math.pow(d, 2));
		var numberList = new LinkedList<Long>();
		numberList.add(a * b + c * d);
		numberList.add(a * c + b * d);
		numberList.add(a * d + c * b);

		numberList.add(a * b - c * d);
		numberList.add(a * c - b * d);
		numberList.add(a * d - c * b);

		numberList.add(-(a * b) + c * d);
		numberList.add(-(a * c) + b * d);
		numberList.add(-(a * d) + c * b);

		var test = numberList.stream().distinct().filter(e -> Math.pow(e , 2) <= number / 2).sorted().collect(Collectors.toList());
		for (var x: test) {
//		for (long x = 0; Math.pow(x, 2) <= number; x++) {
			var y = Math.sqrt(number - Math.pow(x, 2));
			if (y % 1 ==0 && Math.pow(x, 2) + Math.pow(y, 2) == number) {
				answer.add(new long[]{(long) Math.min(x, y), (long) Math.max(x, y)});
			}
		}
		return answer.stream().filter(e -> e[0] > 0 && e[1] > 0).collect(Collectors.toList());
	}

















	public static List<long[]> prod2Sum1(long a, long b, long c, long d) {
//		System.out.println(a + " " + b + " " + c + " " + d);
		var answer = new LinkedList<long[]>();
		var number = (Math.pow(a, 2) + Math.pow(b, 2)) * (Math.pow(c, 2) + Math.pow(d, 2));
		for (long x = 0; Math.pow(x, 2) <= number; x++) {
			var y = Math.sqrt(number - Math.pow(x, 2));
			if (y % 1 ==0 && Math.pow(x, 2) + Math.pow(y, 2) == number) {
				answer.add(new long[]{(long) Math.min(x, y), (long) Math.max(x, y)});
			}
		}
		return answer.stream().distinct().collect(Collectors.toList());
	}
}
