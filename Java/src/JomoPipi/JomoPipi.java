package JomoPipi;

import java.util.LinkedList;
import java.util.List;

public class JomoPipi {

	public static char[][] shift(char[][]m, int n){
		List<Character> list = new LinkedList<>();
		for (int y = 0; y < m.length; y++) {
			for (int x = 0; x < m[y].length; x++) {
				list.add(m[y][x]);
			}
		}
		while (n-- > 0) {
			char buff = list.remove(list.size() - 1);
			list.add(0, buff);
		}

		for (int y = 0; y < m.length; y++) {
			for (int x = 0; x < m[y].length; x++) {
				m[y][x] = list.remove(0);
			}
		}
		return m;
	}
}
