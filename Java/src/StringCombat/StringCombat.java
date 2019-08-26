package StringCombat;

import java.util.List;
import java.util.stream.Collectors;

public class StringCombat {

	public static void main(String[] args) {

	}

	public static String combat(String s1, String s2) {
		if (s1 == null || s2 == null)return "Draw";
		if (s1 == null && s2.length() == 0) return "Draw";
		if (s2 == null && s1.length() == 0) return "Draw";
		if (s1 == null) return "Winner: s2(" + s2 + ")";
		if (s2 == null) return "Winner: s1(" + s1 + ")";
		List<Integer> s1arr = s1.chars().map(c -> (Character.isUpperCase(c)) ? c - 38 : c - 96).boxed().collect(Collectors.toList());
		List<Integer> s2arr = s2.chars().map(c -> (Character.isUpperCase(c)) ? c - 38 : c - 96).boxed().collect(Collectors.toList());
		while (s1arr.size() > 0 && s2arr.size() > 0) {
			int s1Int = s1arr.remove(0);
			int s2Int = s2arr.remove(0);
			if (s1Int > s2Int) {
				s1Int = (int) Math.round(s1Int / (double) 3);
				s1arr.add(0, s1Int);
			} else if (s1Int < s2Int) {
				s2Int = (int) Math.round(s2Int / (double) 3);
				s2arr.add(0, s2Int);
			}
		}
		if (s1arr.size() == 0 && s2arr.size() == 0) {
			return "Draw";
		}
		s1arr = s1arr.stream().map(i -> (i > 26) ? (i + 38) : (i + 96)).collect(Collectors.toList());
		s2arr = s2arr.stream().map(i -> (i > 26) ? (i + 38) : (i + 96)).collect(Collectors.toList());
		return (s1arr.size() > 0)
				? "Winner: s1(" + s1arr.stream().map(Character::toString).collect(Collectors.joining()) + ")"
				: "Winner: s2(" + s2arr.stream().map(Character::toString).collect(Collectors.joining()) + ")";
	}
}
