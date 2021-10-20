package connect_the_dots.kyu6;

import java.util.Arrays;
import java.util.TreeMap;
import java.util.stream.Collectors;

class Dinglemouse {

	public static String connectTheDots(String paper) {
		var split = paper.split("\n");
		var sizeY = split.length;
		var sizeX = split[0].length();
		var coordinates = new TreeMap<Character, int[]>();
		for (var y = 0; y < sizeY; y++) {
			for (var x = 0; x < sizeX; x++) {
				if (split[y].charAt(x) != ' ') {
					coordinates.put(split[y].charAt(x), new int[]{y, x});
				}
			}
		}
		var first = coordinates.get('a');
		var second = coordinates.get('b');
		var y = 0;
		var x = 1;
		var array = new char[sizeY][sizeX];
		for (var yf = 0; yf < sizeY; yf++) {
			for (var xf = 0; xf < sizeX; xf++) {
				array[yf][xf] = ' ';
			}
		}
		for (var one : "cdefghijklmnopqrstuvwxyz".substring(0, coordinates.size() - 1).toCharArray()) {
			if (first[y] == second[y]) {
				var y1 = first[y];
				for (var x1 = Math.min(first[x], second[x]); x1 <= Math.max(first[x], second[x]); x1++) {
					array[y1][x1] = '*';
				}
			} else if (first[x] == second[x]) {
				var x1 = first[x];
				for (var y1 = Math.min(first[y], second[y]); y1 <= Math.max(first[y], second[y]); y1++) {
					array[y1][x1] = '*';
				}
			} else {
				var yDir = (first[y] < second[y]) ? 1 : -1;
				var xDir = (first[x] < second[x]) ? 1 : -1;
				var y1 = 0;
				var x1 = 0;
				for (y1 = first[y], x1 = first[x]; ; y1 += yDir, x1 += xDir) {
					array[y1][x1] = '*';
					if (y1 == second[y]) {
						break;
					}
				}
			}
			first = new int[]{second[0], second[1]};
			if (coordinates.containsKey(one)) {
				second = coordinates.get(one);
			} else {
				second = coordinates.get('a');
			}

		}
		return Arrays.stream(array).map(String::valueOf).collect(Collectors.joining("\n")) + "\n";
	}
}
