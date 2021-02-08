package Silly_16_18_214.kyu7;

import java.util.stream.Collectors;

public class SillyAdditon {

	public static void main(String[] args) {
		System.out.println(add(16, 18));
	}

	public static int add(int num1, int num2) {
		var num1Arr = new StringBuilder(String.valueOf(num1)).reverse().chars().mapToObj(c -> (char) c).collect(Collectors.toList());
		var num2Arr = new StringBuilder(String.valueOf(num2)).reverse().chars().mapToObj(c -> (char) c).collect(Collectors.toList());
		StringBuilder answer = new StringBuilder();
		for (var i = 0; i < Math.max(num1Arr.size(), num2Arr.size()); i++) {
			if (num1Arr.size() > i && num2Arr.size() > i) {
				answer.insert(0, Integer.parseInt(String.valueOf(num1Arr.get(i))) + Integer.parseInt(String.valueOf(num2Arr.get(i))));
			} else if (num1Arr.size() <= i) {
				answer.insert(0, Integer.parseInt(String.valueOf(num2Arr.get(i))));
			} else {
				answer.insert(0, Integer.parseInt(String.valueOf(num1Arr.get(i))));
			}
		}
		return Integer.parseInt(answer.toString()) ;
	}
}
