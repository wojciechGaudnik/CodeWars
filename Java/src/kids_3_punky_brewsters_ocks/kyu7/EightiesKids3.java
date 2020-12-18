package kids_3_punky_brewsters_ocks.kyu7;

import java.util.Arrays;
import java.util.stream.Collectors;

public class EightiesKids3 {

	public static void main(String[] args) {
		System.out.println(getSocks("Punky", new String[] { "pink", "argyle", "argyle" }));
	}

	public static String[] getSocks(String name, String[] socks) {
		if (name.equals("Punky")) {
			var answer = Arrays.stream(socks).collect(Collectors.toSet());
			if (answer.size() > 1) {
				return answer.stream().limit(2).toArray(String[]::new);
			}
		} else if (name.equals("Henry")) {
			for (var one: socks) {
				if (Arrays.stream(socks).filter(s -> s.equals(one)).count() > 1) {
					return new String[]{one, one};
				}
			}
		}
		return new String[0];
	}
}
