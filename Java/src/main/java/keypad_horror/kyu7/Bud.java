package keypad_horror.kyu7;

import java.util.HashMap;

public class Bud {

	public static String computerToPhone(String number) {
		var map = new HashMap<Character, String>();
		map.put('7', "1");
		map.put('8', "2");
		map.put('9', "3");
		map.put('4', "4");
		map.put('5', "5");
		map.put('6', "6");
		map.put('1', "7");
		map.put('2', "8");
		map.put('3', "9");
		map.put('0', "0");
		var answer = new StringBuilder();
		for (var one : number.toCharArray()) {
			answer.append(map.get(one));
		}
		return answer.toString();
	}

}