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
//		prod2Sum(1, 20, -4, -5).forEach(e -> System.out.println(Arrays.toString(e)));
		prod2Sum(39, 31, 12, 171).forEach(e -> System.out.println(Arrays.toString(e)));
	}

	public static List<long[]> prod2Sum(long a, long b, long c, long d) {

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

//		numberList.add(-(c * d) + a * b);
//		numberList.add(-(b * d) + a * c);
//		numberList.add(-(c * b) + a * d);

		long number = (long) ((Math.pow(a, 2) + Math.pow(b, 2)) * (Math.pow(c, 2) + Math.pow(d, 2)));
		var answer = new LinkedList<long[]>();
		for (int e = 1; Math.pow(e, 2) < number; e++) {
			for (int f = 1; Math.pow(f, 2) < number; f++) {
				if (Math.pow(e, 2) + Math.pow(f, 2) == number && numberList.contains((long)e) && numberList.contains((long)f)) {
					answer.add(new long[]{e, f});
				}
			}
		}
		return answer;
	}


	public static List<long[]> prod2Sum3(long a, long b, long c, long d) {
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
		long number = (long) ((Math.pow(a, 2) + Math.pow(b, 2)) * (Math.pow(c, 2) + Math.pow(d, 2)));
		System.out.println(number);
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

//		numberList.add(-(c * d) + a * b);
//		numberList.add(-(b * d) + a * c);
//		numberList.add(-(c * b) + a * d);

		var test = numberList.stream().distinct().sorted().collect(Collectors.toList());
		System.out.println(test);
		for (var x : test) {
//		for (long x = 0; Math.pow(x, 2) <= number; x++) {
			var y = (long) Math.sqrt(number - Math.pow(x, 2));
			if (Math.pow(x, 2) + Math.pow(y, 2) == number && test.contains(y)) {
				answer.add(new long[]{(long) Math.min(x, y), (long) Math.max(x, y)});
			}
		}
		var answer2 = new LinkedList<long[]>();
		for (var one : answer.stream().filter(e -> e[0] > 0 && e[1] > 0).collect(Collectors.toList())) {
			if (answer2.stream().noneMatch(e -> e[0] == one[0])) {
				answer2.add(one);
			}
		}
		return answer2;
//		return answer.stream().filter(e -> e[0] > 0 && e[1] > 0).collect(Collectors.toList());
	}


	public static List<long[]> prod2Sum1(long a, long b, long c, long d) {
//		System.out.println(a + " " + b + " " + c + " " + d);
		var answer = new LinkedList<long[]>();
		var number = (Math.pow(a, 2) + Math.pow(b, 2)) * (Math.pow(c, 2) + Math.pow(d, 2));
		for (long x = 0; Math.pow(x, 2) <= number; x++) {
			var y = Math.sqrt(number - Math.pow(x, 2));
			if (y % 1 == 0 && Math.pow(x, 2) + Math.pow(y, 2) == number) {
				answer.add(new long[]{(long) Math.min(x, y), (long) Math.max(x, y)});
			}
		}
		return answer.stream().distinct().collect(Collectors.toList());
	}
}
