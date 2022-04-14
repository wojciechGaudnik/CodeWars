package vin_checker.kyu6;

import java.util.HashMap;

class CodeWars {
	public static void main(String[] args) {
		System.out.println(checkVin("5YJ3E1EA7HF000337"));
	}

	public static boolean checkVin(String vin) {
		if (vin.length() != 17) {
			return false;
		}
		if (vin.contains("I") || vin.contains("O") || vin.contains("Q")) {
			return false;
		}
		for (var one : vin.toCharArray()) {
			if (Character.isLowerCase(one)) {
				return false;
			}
		}
		HashMap<Character, Integer> map = getCharacterIntegerHashMap();
		var vinNumbers = new StringBuilder();
		for (var one : vin.toCharArray()) {
			if (map.containsKey(one)) {
				vinNumbers.append(map.get(one));
			} else {
				vinNumbers.append(one);
			}
		}
		var weights = new int[]{8, 7, 6, 5, 4, 3, 2, 10, 0, 9, 8, 7, 6, 5, 4, 3, 2};
		var sum = 0;
		for (var i = 0; i < vinNumbers.length(); i++) {
			sum += Integer.parseInt(String.valueOf(vinNumbers.charAt(i))) * weights[i];
		}
		var mod11 = sum % 11;
		if (mod11 == 10 && vin.charAt(8) == 'X') {
			return true;
		}
		if (Character.getNumericValue(vin.charAt(8)) == mod11) {
			return true;
		}
		return false;
	}

	private static HashMap<Character, Integer> getCharacterIntegerHashMap() {
		var map = new HashMap<Character, Integer>();
		map.put('A', 1);
		map.put('B', 2);
		map.put('C', 3);
		map.put('D', 4);
		map.put('E', 5);
		map.put('F', 6);
		map.put('G', 7);
		map.put('H', 8);
		map.put('J', 1);
		map.put('K', 2);
		map.put('L', 3);
		map.put('M', 4);
		map.put('N', 5);
		map.put('P', 7);
		map.put('R', 9);
		map.put('S', 2);
		map.put('T', 3);
		map.put('U', 4);
		map.put('V', 5);
		map.put('W', 6);
		map.put('X', 7);
		map.put('Y', 8);
		map.put('Z', 9);
		return map;
	}
}
