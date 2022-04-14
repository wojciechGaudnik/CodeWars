package c_wars.kyu7;

public class CWars {

	public static String initials(String name) { //<--- broken ??? on codeWars ?
		if (name == null) {
			return null;
		}
		if (name.equals("")) {
			return "";
		}
		String[] split = name.split(" ");
		StringBuilder answer = new StringBuilder();
		for (int i = 0; i < split.length - 1; i++) {
			answer.append(Character.toUpperCase(split[i].charAt(0))).append(".");
		}
		String last = Character.toUpperCase(split[split.length - 1].charAt(0)) + split[split.length - 1].substring(1);
		return answer.append(last).toString();
	}
}
