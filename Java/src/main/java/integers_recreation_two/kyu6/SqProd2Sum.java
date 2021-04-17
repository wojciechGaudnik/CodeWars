package integers_recreation_two.kyu6;

import java.util.Arrays;
import java.util.Collections;
import java.util.LinkedList;
import java.util.List;
import java.util.stream.Collectors;

public class SqProd2Sum {

	public static void main(String[] args) {
		System.out.println("1");
		System.out.println("2");
	}
	public static List<long[]> prod2Sum(long a, long b, long c, long d) {
		var answer = new LinkedList<long[]>();
		long number = (long) ((Math.pow(a, 2) + Math.pow(b, 2)) * (Math.pow(c, 2) + Math.pow(d, 2)));
		List<Long> numberList = new LinkedList<Long>();
		numberList.add(a * b + c * d);
		numberList.add(a * c + b * d);
		numberList.add(a * d + c * b);

		numberList.add(a * b - c * d);
		numberList.add(a * c - b * d);
		numberList.add(a * d - c * b);

		numberList.add(-(a * b) + c * d);
		numberList.add(-(a * c) + b * d);
		numberList.add(-(a * d) + c * b);
		numberList = numberList.stream().distinct().sorted().collect(Collectors.toList());
		for (var ei = 0; ei < numberList.size(); ei++) {
			for (var fi = ei; fi < numberList.size(); fi++) {
				var e = Math.pow(numberList.get(ei), 2);
				var f = Math.pow(numberList.get(fi), 2);
				if (e + f == number) {
					answer.add(new long[]{numberList.get(ei), numberList.get(fi)});
				}
			}
		}
		var answer2 = new LinkedList<long[]>();
		for (var one : answer) {
			var temp = Arrays.stream(one).map(Math::abs).sorted().toArray();
			if (answer2.stream().noneMatch(e -> (e[0] == temp[0] && e[1] == temp[1]))) {
				answer2.add(temp);
			}
		}
		Collections.reverse(answer2);
		return answer2;
	}
}

