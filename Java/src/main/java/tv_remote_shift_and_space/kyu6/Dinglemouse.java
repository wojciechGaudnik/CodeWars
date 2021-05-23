package tv_remote_shift_and_space.kyu6;

import java.util.HashMap;
import java.util.Map;

public class Dinglemouse {

	private static int answer = 0;
	private static int x = 2;
	private static int y = 1;
	private static int shift = 3;

	private static Map<Character, int[]> remote = new HashMap<>();

	static {
		remote.put('a', new int[]{0, 0});
		remote.put('b', new int[]{0, 1});
		remote.put('c', new int[]{0, 2});
		remote.put('d', new int[]{0, 3});
		remote.put('e', new int[]{0, 4});
		remote.put('1', new int[]{0, 5});
		remote.put('2', new int[]{0, 6});
		remote.put('3', new int[]{0, 7});

		remote.put('f', new int[]{1, 0});
		remote.put('g', new int[]{1, 1});
		remote.put('h', new int[]{1, 2});
		remote.put('i', new int[]{1, 3});
		remote.put('j', new int[]{1, 4});
		remote.put('4', new int[]{1, 5});
		remote.put('5', new int[]{1, 6});
		remote.put('6', new int[]{1, 7});

		remote.put('k', new int[]{2, 0});
		remote.put('l', new int[]{2, 1});
		remote.put('m', new int[]{2, 2});
		remote.put('n', new int[]{2, 3});
		remote.put('o', new int[]{2, 4});
		remote.put('7', new int[]{2, 5});
		remote.put('8', new int[]{2, 6});
		remote.put('9', new int[]{2, 7});

		remote.put('p', new int[]{3, 0});
		remote.put('q', new int[]{3, 1});
		remote.put('r', new int[]{3, 2});
		remote.put('s', new int[]{3, 3});
		remote.put('t', new int[]{3, 4});
		remote.put('.', new int[]{3, 5});
		remote.put('@', new int[]{3, 6});
		remote.put('0', new int[]{3, 7});

		remote.put('u', new int[]{4, 0});
		remote.put('v', new int[]{4, 1});
		remote.put('w', new int[]{4, 2});
		remote.put('x', new int[]{4, 3});
		remote.put('y', new int[]{4, 4});
		remote.put('z', new int[]{4, 5});
		remote.put('_', new int[]{4, 6});
		remote.put('/', new int[]{4, 7});

		remote.put('A', new int[]{5, 0});
		remote.put(' ', new int[]{5, 1});
	}

	private static String special = "1234567890.@_/ ";
	private static int[] pass = new int[]{0, 0, 0, 0};

	public static int tvRemote(final String words) {
		pass = new int[]{0, 0, 0, 0};
		for (var one : words.toCharArray()) {
			if (special.contains(String.valueOf(one))) {
				calculate(pass, one);
			} else if (Character.isLowerCase(one) && pass[shift] == 0) {
				calculate(pass, one);
			} else if (Character.isLowerCase(one) && pass[shift] == 1) {
				calculate(pass, 'A');
				pass[shift] = 0;
				calculate(pass, one);
			} else if (Character.isUpperCase(one) && pass[shift] == 1) {
				calculate(pass, Character.toLowerCase(one));
			} else if (Character.isUpperCase(one) && pass[shift] == 0) {
				calculate(pass, 'A');
				pass[shift] = 1;
				calculate(pass, Character.toLowerCase(one));
			}

		}
		return pass[answer];
	}

	private static void calculate(int[] pass, char one) {
		pass[answer] += (Math.abs(remote.get(one)[0] - pass[y]) + Math.abs(remote.get(one)[1] - pass[x]) + 1);
		pass[y] = remote.get(one)[0];
		pass[x] = remote.get(one)[1];
	}
}
